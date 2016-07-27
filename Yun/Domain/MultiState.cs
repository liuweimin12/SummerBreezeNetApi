
using System.Xml.Serialization;

namespace Yun.Domain
{
    public class MultiState
    {
        [XmlElement("id")]
        public long Id { get; set; }

        [XmlElement("state")]
        public int State { get; set; }
    }
}
