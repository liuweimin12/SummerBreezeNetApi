using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class ExpressTemplateResponse : YunResponse
    {
        [XmlArray("freight_templates")]
        [XmlArrayItem("freight_template")]
        public List<DeliveryTemplate> FreightTemplates { get; set; }
    }
}
