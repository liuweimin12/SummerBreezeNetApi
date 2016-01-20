using System;
using System.Collections.Generic;
using Yun.Domain;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class AddExpressTradeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 订单扩展字段
        /// </summary>
        public string Ext { get; set; }

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
        /// 需要使用的积分，抵扣现金
        /// </summary>
        public int Integral { get; set; }


        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string RealName { get; set; }


        /// <summary>
        /// 收货人地址
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// 收货人邮编
        /// </summary>
        public string Zipcode { get; set; }


        /// <summary>
        /// 递送备注，例如收货时间等
        /// </summary>
        public string ExpressRemark { get; set; }


        /// <summary>
        /// 发货类型
        /// </summary>
        public string DeliveryType { get; set; }



        /// <summary>
        /// 商品级别的促销活动的ID
        /// </summary>
        public int PromotionsActivityIdInItem { get; set; }


        /// <summary>
        /// 店铺级别的促销活动的ID
        /// </summary>
        public int PromotionsActivityIdInShop { get; set; }


        /// <summary>
        /// 赠送的商品ID
        /// </summary>
        public List<TradeGiftJson> GiftsJson { get; set; }


        /// <summary>
        /// 到账模式
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// 代金券ID
        /// </summary>
        public int CashCouponId { get; set; }


        /// <summary>
        /// 订单创建时间，可以人为指定
        /// </summary>
        public DateTime? CreateTime { get; set; }
        
        public string GetApiName()
        {
            return "chenggou.trade.express.add";
        }

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
                {"deliverytype", DeliveryType},
                {"integral", Integral},
                {"realname", RealName},
                {"address", Address},
                {"zipcode", Zipcode},
                {"expressremark", ExpressRemark},
                {"promotionsactivityidinitem",PromotionsActivityIdInItem},
                {"promotionsactivityidinshop",PromotionsActivityIdInShop},
                {"giftsjson", GiftsJson},
                {"transactiontype",TransactionType},
                {"ext",Ext},
                {"cashcouponid",CashCouponId},
                {"createtime",CreateTime}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateRequired("tradenum", TradeNum);
            RequestValidator.ValidateMinValue("itemid", ItemId, 1);
            RequestValidator.ValidateMinValue("quantity", Quantity, 1);
        }
    }
}
