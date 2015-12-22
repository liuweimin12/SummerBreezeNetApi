using System.Xml.Serialization;

namespace Yun.Distribution
{
    public class DistributionLevelDomain
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [XmlElement("template_id")]
        public int TemplateId { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }


        /// <summary>
        /// 分成比例
        /// </summary>
        [XmlElement("proportion")]
        public double Proportion { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
