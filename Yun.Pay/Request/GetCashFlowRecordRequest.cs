using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取现金流的记录
    /// yun.cashflow.record.get
    /// </summary>
    public class GetCashFlowRecordRequest : ITopRequest<GetCashFlowRecordResponse>
    {
        /// <summary>
        /// 现金流记录ID
        /// </summary>
        public long CashFlowRecordId { get; set; }

        public string GetApiName()
        {
            return "yun.cashflow.record.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cashflowrecordid", CashFlowRecordId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cashflowrecordid", CashFlowRecordId);
            RequestValidator.ValidateMinValue("cashflowrecordid", CashFlowRecordId, 1);
        }
    }
}