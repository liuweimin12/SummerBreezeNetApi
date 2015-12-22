using System.Xml.Serialization;

namespace Yun.Pay
{
    public class PrepaidCardHistoryDomain
    {
        /// <summary>
        /// 店铺名字
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 充值卡卡号
        /// </summary>
        [XmlElement("card_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// 卡名字
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 当时的卡余额
        /// </summary>
        [XmlElement("balance")]
        public double Balance { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_id")]
        public int CardId { get; set; }


        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        [XmlElement("card_type_id")]
        public int CardTypeId { get; set; }


        /// <summary>
        /// 动作
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }


        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 操作人ID 
        /// </summary>
        [XmlElement("operator_id")]
        public int OperatorId { get; set; }


        [XmlElement("operator_nick")]
        public string OperatorNick { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }


        /// <summary>
        /// 外部订单或者详情ID
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }


        /// <summary>
        /// 记录描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
