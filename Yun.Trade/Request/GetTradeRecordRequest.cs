using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取交易记录
    /// </summary>
    public class GetTradeRecordRequest : ITopRequest<TradeRecordResponse>
     {
         /// <summary>
         /// 页码
         /// </summary>
         public int PageNum
         {
             get { return _pageNum; }
             set
             {
                 _pageNum = value < 1 ? 1 : value;
             }
         }

         private int _pageNum = 1;

         /// <summary>
         /// 页容量
         /// </summary>
         public int PageSize
         {
             get { return _pageSize; }
             set
             {
                 _pageSize = value < 1 ? 1 : value;
             }
         }

         private int _pageSize = 1;

         /// <summary>
         /// 商品ID
         /// </summary>
         public int ItemId { get; set; }

        public int? ShopId { get; set; }

        public string GetApiName()
        {
            return "chenggou.traderecords.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"itemid", ItemId},
                {"shopid", ShopId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
     }
}
