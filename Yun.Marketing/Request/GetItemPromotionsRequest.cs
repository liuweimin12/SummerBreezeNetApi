using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Marketing.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 商品优惠详情查询
    /// chenggou.item.promotion.get
    /// </summary>
    public class GetItemPromotionsRequest : ITopRequest<GetItemPromotionsResponse>
    {
         
        /// <summary>
        /// 商品id
        /// </summary>
        public int ItemId { get; set; }
        public string GetApiName()
        {
            return "chenggou.item.promotion.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
