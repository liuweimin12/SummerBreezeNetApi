using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetPrepaidCardHistoryResponse : YunResponse,IPageResponse
    {
        /// <summary>
        /// 充值卡记录数据
        /// </summary>
        [XmlArray("prepaid_card_histories")]
        [XmlArrayItem("prepaid_card_history")]
        public List<PrepaidCardHistoryDomain> PrepaidCardHistories { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("total_money")]
        public double TotalMoney { get; set; }
    }
}
