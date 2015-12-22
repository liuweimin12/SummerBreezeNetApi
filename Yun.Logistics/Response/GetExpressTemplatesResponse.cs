using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class GetExpressTemplatesResponse : YunResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlArray("freight_templates")]
        [XmlArrayItem("freight_template")]
        public List<DeliveryTemplate> Result { get; set; }
    }
}
