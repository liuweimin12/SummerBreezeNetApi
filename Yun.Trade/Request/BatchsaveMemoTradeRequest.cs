using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class BatchSaveMemoTradeRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订单ID，多个用英文逗号进行分割
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 备注内容
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 标识，可自定义
        /// </summary>
        public int Flag { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.memo.batchsave";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids",Ids},
                {"memo",Memo},
                {"flag",Flag}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
            RequestValidator.ValidateRequired("flag", Flag);
        }
    }
}
