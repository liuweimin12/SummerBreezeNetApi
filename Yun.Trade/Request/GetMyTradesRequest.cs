using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class GetMyTradesRequest : ITopRequest<TradesResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量，最大不能超过40
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 商品名称：模糊查询
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 成交时间，搜索一段时间内成交的数据
        /// </summary>
        public long MinCreateTime { get; set; }


        /// <summary>
        /// 成交时间
        /// </summary>
        public long MaxCreateTime { get; set; }

        /// <summary>
        /// 购买人用户名
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 收货地址中的手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 订单状态
        ///ALL(全部),
        ///NOT_PAID(等待买家付款),
        ///PAID(等待发货),
        ///SEND(已发货),
        ///REFUNDING(退款中),
        ///SUCCESS(成功的订单),
        ///DROP(关闭的订单),
        ///EXCEPTIONAL(异常订单)
        ///以上选项只能单选
        /// </summary>
        public string TradeStatus { get; set; }

        /// <summary>
        /// 评价状态
        ///ALL(全部)
        ///I_HAS_NOT_COMMENT(需我评价)
        ///I_HAS_COMMENT(我已评价)
        ///OTHER_HAS_COMMENT(对方已评)
        ///ALL_COMMENT(双方已评)
        ///以上选项只能单选
        /// </summary>
        public string CommentStatus { get; set; }

        /// <summary>
        /// 物流状态
        //ALL(所有)
        //COD(货到付款)
        //以上选项只能单选
        /// </summary>
        public string LogisticsService { get; set; }

        /// <summary>
        /// 交易类型
        ///FIXED(一口价)
        ///AUCTION(拍卖)
        ///GUARANTEE_TRADE(担保交易)
        ///AUTO_DELIVERY(自动发货)
        ///INDEPENDENT_SIMPLE_TRADE(入门版交易)
        ///INDEPENDENT_SHOP_TRADE(标准版交易)
        ///EC(直冲)
        ///COD(货到付款)
        ///FENXIAO(分销)
        ///GAME_EQUIPMENT(游戏装备)
        ///EXTERNAL_TRADE(统一外部交易)
        ///TUAN(团购)
        ///NOPAID(无付款订单)
        ///PRE_AUTH_TYPE(元购机交易)
        ///FUWU(服务)
        ///IMMEDIATE(即时到账)
        ///以上内容可多选，多选后用英文逗号进行分割
        /// </summary>
        public string Type { get; set; }


        /// <summary>
        /// 商品ID，多个用英文逗号分隔
        /// </summary>
        public IList<int> ItemIds { get; set; }

        /// <summary>
        /// 订单类型，多个用英文逗号分隔
        /// </summary>
        public string OrderTypes { get; set; }

        /// <summary>
        /// 获取哪家店铺的ID
        /// </summary>
        public int ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.trades.buy.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"itemtitle", ItemTitle},
                {"mincreatetime", MinCreateTime},
                {"maxcreatetime", MaxCreateTime},
                {"nick", Nick},
                {"orderid", OrderId},
                {"mobile", Mobile},
                {"tradestatus", TradeStatus},
                {"commentstatus", CommentStatus},
                {"logisticsservice", LogisticsService},
                {"type", Type},
                {"itemids", ItemIds != null && ItemIds.Any() ? string.Join(",", ItemIds) : ""},
                {"ordertypes", OrderTypes},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("itemtitle", this.ItemTitle, 200);
            RequestValidator.ValidateMaxLength("nick", this.Nick, 200);
            RequestValidator.ValidateMaxLength("mobile", this.Mobile, 20);
            RequestValidator.ValidateMaxLength("tradestatus", this.TradeStatus, 50);
            RequestValidator.ValidateMaxLength("commentstatus", this.CommentStatus, 50);
            RequestValidator.ValidateMaxLength("logisticsservice", this.LogisticsService, 50);
            RequestValidator.ValidateMaxLength("type", this.Type, 50);
        }
    }
}
