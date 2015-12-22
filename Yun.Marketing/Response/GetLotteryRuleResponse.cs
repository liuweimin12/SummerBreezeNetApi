using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_lottery_rule_response")]
    public class GetLotteryRuleResponse : YunResponse
    {
        [XmlElement("lottery_rule")]
        public Lottery LotteryRule { get; set; }
    }
}
