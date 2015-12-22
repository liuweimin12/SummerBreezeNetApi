using System.Xml.Serialization;
namespace Yun.Item
{
     public class ShopItemCategory
    {
         /// <summary>
        /// 文章ID
         /// </summary>
         [XmlElement("id")]
         public long Id { get; set; }

         /// <summary>
         /// 是否显示
         /// </summary>
         [XmlElement("display")]
         public bool Display { get; set; }

         /// <summary>
         /// 缩略图的完整URL
         /// </summary>
         [XmlElement("image")]
         public string Image { get; set; }

         /// <summary>
         /// 父ID
         /// </summary>
         [XmlElement("parent_id")]
         public long ParentId { get; set; }

         /// <summary>
         /// 排序
         /// </summary>
         [XmlElement("sort")]
         public long Sort { get; set; }

         /// <summary>
         /// 名称
         /// </summary>
         [XmlElement("title")]
         public string Title { get; set; }

         /// <summary>
         /// 描述
         /// </summary>
         [XmlElement("description")]
         public string Description { get; set; }
    }
}
