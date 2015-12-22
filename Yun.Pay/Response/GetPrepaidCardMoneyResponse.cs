
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetPrepaidCardMoneyResponse : YunResponse
    {
        /// <summary>
        /// 未过期的余额
        /// </summary>
        [XmlElement("not_expired_money")]
        public double NotExpiredMoney { get; set; }
    }
}
