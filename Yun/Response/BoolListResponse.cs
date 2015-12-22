using System.Xml.Serialization;
namespace Yun.Response
{
    public class BoolListResponse : ChengResponse
    {
        [XmlArray("results")]
        [XmlArrayItem("results")]
        public bool[] Results { get; set; }
    }
}
