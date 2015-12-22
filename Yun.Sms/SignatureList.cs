using System.Xml.Serialization;
namespace Yun.Sms
{
    public class SignatureList : Signature
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }
    }
}
