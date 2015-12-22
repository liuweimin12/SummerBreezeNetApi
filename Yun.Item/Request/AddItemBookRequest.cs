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
    /// 新增商品预定
    /// chenggou.item.book.add
    /// </summary>
    public class AddItemBookRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 所选择商品的SKUID
        /// </summary>
        public int SkuId { get; set; }


        /// <summary>
        /// 需要预定的数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 预定人手机
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 预定人姓名
        /// </summary>
        public string BookerName { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.book.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid",ItemId},
                {"skuid",SkuId},
                {"quantity",Quantity},
                {"mobile",Mobile},
                {"bookername",BookerName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
