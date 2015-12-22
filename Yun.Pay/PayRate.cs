
using System.Xml.Serialization;
namespace Yun.Pay
{
    public class PayRate : OnlinePayRate
    {
        /// <summary>
        /// 是否自己设置在线付款信息
        /// </summary>
        [XmlElement("use_self")]
        public bool UseSelf { get; set; }
    }
}
