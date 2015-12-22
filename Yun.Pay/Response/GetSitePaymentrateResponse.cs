using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetSitePaymentrateResponse : YunResponse
    {
        /// <summary>
        /// 返回在线付款的手续费
        /// </summary>
        [XmlElement("pay_rate")]
        public PayRate Result { get; set; }
    }
}
