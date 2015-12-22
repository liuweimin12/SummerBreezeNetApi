using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{

    /// <summary>
    /// 更新商品全局类目
    /// chenggou.itemcat.update
    /// </summary>
    public class UpdateItemCatRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分类排序
        /// </summary>
        public double Sort { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcat.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"name",Name},
                {"sort",Sort},
                {"display",Display}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
