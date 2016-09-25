using System.Xml.Serialization;

namespace Yun.Shop
{
    public class ItemCat
    {
        /// <summary>
        /// 主营类目ID
        /// </summary>
        [XmlElement("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// 分类名字
        /// </summary>
        [XmlElement("cat_name")]
        public string CatName { get; set; }
    }
}
