using System.Xml.Serialization;
namespace Yun.Pay
{
    public class OnlinePayRate
    {
        /// <summary>
        /// PC端扣费
        /// </summary>
        [XmlElement("pc")]
        public string Pc { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
