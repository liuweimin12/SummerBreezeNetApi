using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class GetSignatureResponse : YunResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [XmlElement("signature")]
        public Signature Result { get; set; }
    }
}
