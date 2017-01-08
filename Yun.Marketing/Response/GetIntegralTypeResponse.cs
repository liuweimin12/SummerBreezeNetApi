using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_credit_type_response")]
    public class GetIntegralTypeResponse: YunResponse
    {
        /// <summary>
        /// 积分类型
        /// </summary>
        [XmlElement("credit_type")]
        public IntegralType CreditType { get; set; }
    }
}
