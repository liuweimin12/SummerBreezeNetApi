using System.Xml.Serialization;

namespace Yun.Trade
{
    public class MemoModel
    {
        [XmlElement("flag")]
        public int Flag { get; set; }

        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
