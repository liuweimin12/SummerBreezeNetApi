using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_lottery_awards_response")]
    public class FindLotteryAwardsResponse : YunResponse, IPageResponse
    {
        [XmlArray("lottery_awards")]
        [XmlArrayItem("lottery_award")]
        public List<LotteryAward> LotteryAwards { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
