using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GeneratePayHtmlResponse : YunResponse
    {
        /// <summary>
        /// 返回在线支付的HTML跳转代码
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
