using System.Xml.Serialization;

namespace Yun.Item
{
    public class ItemGroupByCat
    {
        /// <summary>
        /// 关键字
        /// </summary>
        [XmlElement("keywords")]
        public string KeyWords { get; set; }

        /// <summary>
        /// 分类ID，最后一级
        /// </summary>
        [XmlElement("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }


        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("goods_count")]
        public int GoodsCount { get; set; }


    }
}
