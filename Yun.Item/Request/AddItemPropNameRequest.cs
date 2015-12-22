using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class AddItemPropNameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int ItemCatId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }


        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 多属性值
        /// </summary>
        public bool HasMultiValues { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// 允许自定义
        /// </summary>
        public bool CanCustomValue { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 特殊标记类型，可自定义，方便以后索搜用，不能超过255，最小为0
        /// </summary>
        public int SpecialType { get; set; }


        public string GetApiName()
        {
            return "chenggou.item.propname.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemcatid", ItemCatId},
                {"name", Name},
                {"hasmultivalues", HasMultiValues},
                {"isrequired", IsRequired},
                {"cancustomvalue", CanCustomValue},
                {"shopid", ShopId},
                {"specialtype", SpecialType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemcatid", ItemCatId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);
            RequestValidator.ValidateRequired("shopid", ShopId);
        }
    }
}
