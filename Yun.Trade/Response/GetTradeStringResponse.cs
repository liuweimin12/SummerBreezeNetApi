using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    public class GetTradeStringResponse:YunResponse
    {
        /// <summary>
        /// 返回具体的扣点数
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
