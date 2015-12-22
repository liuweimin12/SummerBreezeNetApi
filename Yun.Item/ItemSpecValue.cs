using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemSpecValue
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 规格名称ID
        /// </summary>
        [XmlElement("item_spec_name_id")]
        public long ItemSpecNameId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 规格值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
