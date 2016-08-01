using System;
using System.Collections.Generic;
using Yun.Domain;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Coupon.Request
{
    public class AddCouponTradeRequest : ITopRequest<IntResultResponse>
    {
        
        public string GetApiName()
        {
            return "chenggou.trade.coupon.add";
        }

        /// <summary>
        /// 商品级别的促销活动的ID
        /// </summary>
        public int PromotionsActivityIdInItem { get; set; }


        /// <summary>
        /// 店铺级别的促销活动的ID
        /// </summary>
        public int PromotionsActivityIdInShop { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }


        /// <summary>
        /// SKUID
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 订单来源记录
        /// </summary>
        public string SourceUrl { get; set; }


        /// <summary>
        /// 交易标识，32位
        /// </summary>
        public string TradeNum { get; set; }


        /// <summary>
        /// 中国大陆手机号
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 发券类型
        /// </summary>
        public string SendType { get; set; }


        /// <summary>
        /// 需要使用的积分，抵扣现金
        /// </summary>
        public int Integral { get; set; }


        /// <summary>
        /// 赠送的商品ID
        /// </summary>
        public List<TradeGiftJson> GiftsJson { get; set; }


        /// <summary>
        /// 订单扩展字段
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 代金券ID
        /// </summary>
        public int CashCouponId { get; set; }


        /// <summary>
        /// 订单创建时间，可以人为指定
        /// </summary>
        public DateTime? CreateTime { get; set; }


        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string Ext2 { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票内容
        /// </summary>
        public string InvoiceContent { get; set; }


        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"quantity", Quantity},
                {"skuid", SkuId},
                {"remark", Remark},
                {"sourceurl", SourceUrl},
                {"tradenum", TradeNum},
                {"mobile", Mobile},
                {"sendtype", SendType},
                {"integral", Integral},
                {"promotionsactivityidinitem", PromotionsActivityIdInItem},
                {"promotionsactivityidinshop", PromotionsActivityIdInShop},
                {"giftsjson", GiftsJson},
                {"ext", Ext},
                {"cashcouponid", CashCouponId},
                {"createtime", CreateTime},
                {"ext2", Ext2},
                {"invoicetitle", InvoiceTitle},
                {"invoicecontent", InvoiceContent}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateRequired("sendtype", SendType);
            RequestValidator.ValidateRequired("tradenum", TradeNum);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
            RequestValidator.ValidateMinValue("Quantity", Quantity, 1);
        }
    }
}
