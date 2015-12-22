using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Response
{
    public class StringResultResponse : YunResponse
    {

        [XmlElement("string_result")]
        public string Result { get; set; }
    }
}
