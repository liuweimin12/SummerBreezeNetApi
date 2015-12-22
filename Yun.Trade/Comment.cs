using System.Xml.Serialization;

namespace Yun.Trade
{
    public class Comment
    {
        [XmlElement("comment_content")]
        public string Content { get; set; }

        [XmlElement("comment_time")]
        public string CommentTime { get; set; }

        [XmlElement("comment_grade")]
        public string Grade { get; set; }
    }
}
