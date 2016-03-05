using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class GetTradesSoldRequest : ITopRequest<TradesResponse>
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 商品标题，支持模糊查询
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 起始下单时间
        /// </summary>
        public long MinCreateTime { get; set; }

        /// <summary>
        /// 下单时间结束
        /// </summary>
        public long MaxCreateTime { get; set; }

        /// <summary>
        /// 买家昵称或者店铺ID
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 订单iD 
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// 订单收货信息中的手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 订单状态
        ///EXCEPTIONAL
        ///TRADE_CLOSED
        ///TRADE_NO_CREATE_PAY
        ///WAIT_BUYER_PAY
        ///TRADE_CLOSED_BY_SELF
        ///WAIT_SELLER_SEND_GOODS
        ///WAIT_BUYER_CONFIRM_GOODS
        ///TRADE_BUYER_SIGNED
        ///TRADE_FINISHED
        ///SELLER_CONSIGNED_PART
        ///PAY_PENDING
        ///WAIT_PRE_AUTH_CONFIRM
        /// </summary>
        public string TradeStatus { get; set; }

        /// <summary>
        /// 评论状态
        ///ALL
        ///I_HAS_NOT_COMMENT
        ///I_HAS_COMMENT
        ///OTHER_HAS_COMMENT
        ///ALL_COMMENT
        /// </summary>
        public string CommentStatus { get; set; }

        /// <summary>
        /// 物流服务类型
        ///ALL
        ///COD
        /// </summary>
        public string LogisticsService { get; set; }


        public string Type { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 收件人名字
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 是否需要删除的订单
        /// </summary>
        public bool? IsDelete { get; set; }


        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemsId { get; set; }

        /// <summary>
        /// 付款时间起始
        /// </summary>
        public long MinPayTime { get; set; }

        /// <summary>
        /// 付款时间最大
        /// </summary>
        public long MaxPayTime { get; set; }

        /// <summary>
        /// 订单类型，多个用英文逗号分隔
        /// </summary>
        public string OrderTypes { get; set; }

        /// <summary>
        /// 排序规则
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 卖家自定义订单类型
        /// </summary>
        public string CustomTradeType { get; set; }

        public string GetApiName()
        {
            return "chenggou.trades.sold.get";
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
                {"minpaytime", MinPayTime},
                {"maxpaytime", MaxPayTime},
                {"nick", Nick},
                {"orderid", OrderId},
                {"mobile", Mobile},
                {"tradestatus", TradeStatus},
                {"commentstatus", CommentStatus},
                {"logisticsservice", LogisticsService},
                {"type", Type},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"realname", RealName},
                {"isdelete", IsDelete},
                {"itemsid", ItemsId},
                {"ordertypes", OrderTypes},
                {"sort", Sort},
                {"customtradetype", CustomTradeType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
