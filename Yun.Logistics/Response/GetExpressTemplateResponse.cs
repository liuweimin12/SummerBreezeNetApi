using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class GetExpressTemplateResponse : YunResponse
    {
        /// <summary>
        /// 返回店铺下商品物流模板
        /// </summary>
        [XmlElement("fare_template")]
        public DeliveryTemplate Result { get; set; }
    }
}
