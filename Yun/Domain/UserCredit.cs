
using System.Xml.Serialization;

namespace Yun.Domain
{
    public class UserCredit
    {
        [XmlElement("score")]
        public int Score { get; set; }

        [XmlElement("total_num")]
        public int TotalNum { get; set; }

        [XmlElement("good_num")]
        public int GoodNum { get; set; }
    }
}
