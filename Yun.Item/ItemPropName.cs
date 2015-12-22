using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemPropName
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [XmlElement("item_cat_id")]
        public long ItemCatId { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否多属性值
        /// </summary>
        [XmlElement("has_multi_values")]
        public bool HasMultiValues { get; set; }

        /// <summary>
        /// 是否必须
        /// </summary>
        [XmlElement("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// 是否可以自定义
        /// </summary>
        [XmlElement("can_custom_value")]
        public bool CanCustomValue { get; set; }

        /// <summary>
        /// 自定义的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public long  ShopId { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 下面的属性值
        /// </summary>
        [XmlArray("item_prop_values")]
        [XmlArrayItem("item_prop_value")]
        public List<ItemPropValue> ItemPropValues { get; set; }
    }
}
