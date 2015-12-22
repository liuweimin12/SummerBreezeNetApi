using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class AddShopCustomerserviceRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 客服昵称
        /// </summary>
        public string  Nick { get; set; }

        /// <summary>
        /// 是否是女性
        /// </summary>
        public bool IsFemale { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// QQ
        /// </summary>
        public string Qq { get; set; }

        /// <summary>
        /// 旺旺
        /// </summary>
        public string Wangwang { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        public bool Display { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public double Sort { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.customerservice.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"nick", Nick},
                {"isfemale",IsFemale},
                {"phone",Phone},
                {"qq",Qq},
                {"wangwang",Wangwang},
                {"display",Display},
                {"sort",Sort}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", Nick);
            RequestValidator.ValidateRequired("qq", Qq);

        }
    }
}
