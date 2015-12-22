using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Item.Response
{
    public class GetCategoryPrevsResponse: YunResponse
    {
        /// <summary>
        /// 根据当前id获取上级分类
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<LongKeyValuePair> Categories { get; set; }
    }
}
