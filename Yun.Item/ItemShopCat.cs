using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemShopCat
    {
        [XmlElement("id")]
        public long Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}
