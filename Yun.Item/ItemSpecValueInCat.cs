using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemSpecValueInCat
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

     

        /// <summary>
        /// 规格值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
