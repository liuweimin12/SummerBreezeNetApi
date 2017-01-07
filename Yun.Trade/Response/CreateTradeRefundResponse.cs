using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class CreateTradeRefundResponse : YunResponse
    {
        /// <summary>
        /// 退款结果
        /// </summary>
        [XmlArray("create_refund_results")]
        [XmlArrayItem("create_refund_result")]
        public List<CreateRefundResult> CreateRefundResults { get; set; }
    }
}
