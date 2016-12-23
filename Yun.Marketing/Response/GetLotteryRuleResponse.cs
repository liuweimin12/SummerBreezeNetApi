using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_lottery_rule_response")]
    public class GetLotteryRuleResponse : YunResponse
    {
        [XmlArray("lottery_rules")]
        [XmlArrayItem("lottery_rule")]
        public List<Lottery> LotteryRules { get; set; }
    }
}
