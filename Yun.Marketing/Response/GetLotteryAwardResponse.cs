using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_lottery_award_response")]
    public class GetLotteryAwardResponse : YunResponse
    {
        [XmlElement("lottery_award")]
        public LotteryAward LotteryAward { get; set; }
    }
}
