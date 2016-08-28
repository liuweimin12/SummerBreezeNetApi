using System.Xml.Serialization;

namespace Yun.Trade
{
    /// <summary>
    /// 汇率比值模型
    /// 付款方式和用户余额的比值，可以把用户余额和第三方在线付款的金额当作标准货币价格
    /// 其他付款方式和标准货币的比值
    /// 只能按照SITE进行划分
    /// 暂时支持线下金额和充值卡金额，如果后期加入其他付款方式，也可以在这里对应的增加
    /// </summary>
    public class ExchangeRate
    {
        /// <summary>
        /// 1充值卡等于多少标准货币
        /// </summary>
        [XmlElement("prepaid_card_rate")]
        public double PrepaidCardRate { get; set; }

        /// <summary>
        /// 1线下支付金额等于多少标准货币
        /// </summary>
        [XmlElement("cash_rate")]
        public double CashRate { get; set; }
    }
}
