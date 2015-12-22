using System;
using System.Xml.Serialization;

namespace Yun.Domain
{
    public class AlbumDetail
    {
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        [XmlElement("username")]
        public string UserName { get; set; }

        [XmlElement("type")]
        public int Type { get; set; }

        [XmlElement("type_id")]
        public int TypeId { get; set; }

        [XmlElement("display")]
        public bool Display { get; set; }
    }
}
