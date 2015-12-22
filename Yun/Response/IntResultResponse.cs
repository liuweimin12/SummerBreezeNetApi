
using System.Xml.Serialization;
namespace Yun.Response
{
    public class IntResultResponse : YunResponse
    {
        [XmlElement("number_result")]
        public long Result { get; set; }
    }
}
