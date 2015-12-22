using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class SignaturesResponse : YunResponse, IPageResponse
    {
        [XmlArray("signatures")]
        [XmlArrayItem("signature")]
        public List<SignatureList> Signatures { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }

    }
}
