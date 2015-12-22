using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class LogisticsInformationContent
    {
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        [XmlElement("content")]
        public string Context { get; set; }
    }
}
