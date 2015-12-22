using System;
using System.Collections;
using System.Collections.Generic;
using Jayrock.Json;

namespace Yun.Parser
{
    /// <summary>
    /// TOP JSON响应通用读取器。
    /// </summary>
    public class TopJsonReader : ITopReader
    {
        private IDictionary json;

        public TopJsonReader(IDictionary json)
        {
            this.json = json;
        }

        public bool HasReturnField(object name)
        {
            return json.Contains(name);
        }

        public object GetPrimitiveObject(object name)
        {
            return json[name];
        }

        public object GetReferenceObject(object name, Type type, DTopConvert convert)
        {
            var dict = json[name] as IDictionary;
            if (dict != null && dict.Count > 0)
            {
                return convert(new TopJsonReader(dict), type);
            }
            return null;
        }

        public IList GetListObjects(string listName, string itemName, Type type, DTopConvert convert)
        {
            IList listObjs = null;

            var jsonMap = json[listName] as IDictionary;
            if (jsonMap != null && jsonMap.Count > 0)
            {
                var jsonList = jsonMap[itemName] as IList;
                if (jsonList != null && jsonList.Count > 0)
                {
                    var listType = typeof(List<>).MakeGenericType(new[] { type });
                    listObjs = Activator.CreateInstance(listType) as IList;
                    foreach (var item in jsonList)
                    {
                        if (item is IDictionary) // object
                        {
                            var subMap = item as IDictionary;
                            var subObj = convert(new TopJsonReader(subMap), type);
                            if (subObj != null)
                            {
                                listObjs.Add(subObj);
                            }
                        }
                        else if (item is IList) // list or array
                        {
                            // TODO not support yet
                        }
                        else if (item is JsonNumber) // long
                        {
                            listObjs.Add(((JsonNumber)item).ToInt64());
                        }
                        else // string, bool, other
                        {
                            listObjs.Add(item);
                        }
                    }
                }
            }

            return listObjs;
        }
    }
}
