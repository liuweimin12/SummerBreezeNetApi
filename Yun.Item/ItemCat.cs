using System.Xml.Serialization;
namespace Yun.Item
{
     public class ItemCat
    {
         /// <summary>
         /// ID
         /// </summary>
         [XmlElement("id")]
         public long Id { get; set; }

         /// <summary>
         /// 类目名称
         /// </summary>
         [XmlElement("name")]
         public string Name { get; set; }

         /// <summary>
         /// 父类Id
         /// </summary>
         [XmlElement("parent_id")]
         public long ParentId { get; set; }

         /// <summary>
         /// 排序
         /// </summary>
         [XmlElement("sort")]
         public long Sort { get; set; }

         /// <summary>
         /// 是否显示
         /// </summary>
         [XmlElement("display")]
         public bool Display { get; set; }


         /// <summary>
         /// 类目下的商品数量
         /// </summary>
         [XmlElement("item_count")]
         public int ItemCount { get; set; }

         /// <summary>
         /// 商品的SKU数量
         /// </summary>
         [XmlElement("sku_count")]
         public int SkuCount { get; set; }
     }
}
