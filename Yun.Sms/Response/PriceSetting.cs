using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class PriceSetting : YunResponse
    {
        [XmlElement("price")]
        public LongKeyValuePair Price { get; set; }
    }
}
