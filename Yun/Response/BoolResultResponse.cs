using System.Xml.Serialization;
namespace Yun.Response
{

    public class BoolResultResponse : YunResponse
    {
        [XmlElement("bool_result")]
        public bool Result { get; set; }
    }
}
