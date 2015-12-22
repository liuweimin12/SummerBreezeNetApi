using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemPropValueInDetail
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 父属性值Id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
