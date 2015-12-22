using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class IntegralRule
    {
      
        /// <summary>
        /// 规则的自增ID
        /// </summary>
        [XmlElement("rule_id")]
        public int RuleId { get; set; }


        /// <summary>
        /// 规则名字
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 最小积分
        /// </summary>
        [XmlElement("min_integral")]
        public int MinIntegral { get; set; }


        /// <summary>
        /// 最大积分
        /// </summary>
        [XmlElement("max_integral")]
        public int MaxIntegral { get; set; }


        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }


        /// <summary>
        /// 自定义商品名字
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }


        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("goods_description")]
        public string GoodsDescription { get; set; }


        /// <summary>
        /// 库存数
        /// </summary>
        [XmlElement("stock")]
        public int Stock { get; set; }


        /// <summary>
        /// 启用库存
        /// </summary>
        [XmlElement("enabled_stock")]
        public bool EnabledStock { get; set; }
    }
}
