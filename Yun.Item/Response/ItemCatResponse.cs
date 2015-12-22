using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{

    public class ItemCatResponse : YunResponse
    {
        /// <summary>
        /// 分类详情
        /// </summary>
        [XmlElement("item_cat")]
        public ItemCat ItemCat { get; set; }


        /// <summary>
        /// 商品属性名称
        /// </summary>
        [XmlArray("item_props")]
        [XmlArrayItem("item_prop")]
        public List<ItemPropInCat> ItemProps { get; set; }

        /// <summary>
        /// 商品销售属性名称
        /// </summary>
        [XmlArray("item_specs")]
        [XmlArrayItem("item_spec")]
        public List<ItemSpecInCat> ItemSpecs { get; set; }
    }
}
