using System;
using System.Collections.Generic;
using System.Linq;
using Yun.Domain;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class AddmultiExpressTradeRequest : ITopRequest<AddmultiExpressTradeResponse>
    {
        /// <summary>
        /// 订单扩展字段
        /// </summary>
        public string Ext { get; set; }

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


        private string _deliveryType;


        private string _promotionsActivityIdInShop;

        /// <summary>
        /// 所选择的商品信息
        /// itemid,quantity,skuid^itemid,quantity,skuid|itemid,quantity,skuid^itemid,quantity,skuid
        /// </summary>
        public IList<BuyItemBatch> Items { get; set; }


        /// <summary>
        /// 赠送的商品ID
        /// </summary>
        public List<List<TradeGiftJson>> GiftsJson { get; set; }
        
        private string ConvertItems(IEnumerable<BuyItemBatch> items)
        {
            if (items == null) return "";

            var r = "";
            foreach (var item in items)
            {
                _deliveryType += item.DeliveryType + ",";
                _remark += item.Remark + ",";
                _promotionsActivityIdInShop += item.PromotionsActivityIdInShop + ",";

                r = item.Items.Aggregate(r,
                    (current, i) =>
                        current +
                        string.Format("{0},{1},{2},{3}^", i.ItemId, i.Quantity, i.SkuId,
                            i.PromotionsActivityIdInItem));
                r = r.Trim('^') + "|";
            }

            return r;
        }

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


        public string GetApiName()
        {
            return "chenggou.trade.multiexpress.add";
        }

        private string _remark;

        public IDictionary<string, string> GetParameters()
        {
            var items = ConvertItems(Items);
            var parameters = new YunDictionary
            {
                {"items", items.Trim('|')},
                {"remark", _remark.Trim(',')},
                {"sourceurl", SourceUrl},
                {"tradenum", TradeNum},
                {"mobile", Mobile},
                {"deliverytype", _deliveryType.Trim(',')},
                {"integral", Integral},
                {"realname", RealName},
                {"address", Address},
                {"zipcode", Zipcode},
                {"expressremark", ExpressRemark},
                {"promotionsactivitiesidinshop", _promotionsActivityIdInShop.Trim(',')},
                {"giftsjson", GiftsJson},
                {"ext",Ext},
                {"cashcouponid",CashCouponId},
                {"createtime",CreateTime},
                {"ext2", Ext2},
                {"invoicetitle", InvoiceTitle},
                {"invoicecontent", InvoiceContent}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("items", Items);
            RequestValidator.ValidateRequired("tradenum", TradeNum);
        }
    }
}
