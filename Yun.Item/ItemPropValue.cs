using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemPropValue
    {
        /// <summary>
        /// 图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 属性名称ID
        /// </summary>
        [XmlElement("item_prop_name_id")]
        public long ItemPropNameId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

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

        /// <summary>
        /// 是否有子属性
        /// </summary>
        [XmlElement("has_child")]
        public bool HasChild { get; set; }

        [XmlElement("sort")]
        public int Sort { get; set; }


        /// <summary>
        /// 是否隐藏
        /// </summary>
        [XmlElement("is_hide")]
        public bool IsHide { get; set; }
    }
}
