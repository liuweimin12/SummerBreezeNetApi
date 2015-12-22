using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class QuestionResponse : YunResponse
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        [XmlElement("question")]
        public ShopAsk Question { get; set; }
    }
}
