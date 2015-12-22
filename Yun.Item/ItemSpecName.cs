using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemSpecName
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
        /// 规格名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 自定义的店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        [XmlArray("item_spec_values")]
        [XmlArrayItem("item_spec_value")]
        public List<ItemSpecValue> ItemSpecValues { get; set; }
    }
}
