using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取全局类目下拥有的SPU列表
    /// </summary>
    public class GetItemCatPropChildrenRequest : ITopRequest<PropNamesResponse>
    {
        /// <summary>
        /// 父属性值ID
        /// </summary>
        public int ParentValueId { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        public int ItemcatId { get; set; } 


        public string GetApiName()
        {
            return "chenggou.itemcat.prop.children.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentvalueid", ParentValueId },
                {"itemcatid",ItemcatId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("parentvalueid", ParentValueId);
            RequestValidator.ValidateRequired("itemcatid",ItemcatId);
        }
    }
}
