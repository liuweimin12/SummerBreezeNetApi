using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 新增全局商品类目
    /// </summary>
    public class AddItemCatsRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "chenggou.itemcat.add";
        }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool? Display { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentid", ParentId},
                {"name",Name},
                {"sort",Sort},
                {"display",Display}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
