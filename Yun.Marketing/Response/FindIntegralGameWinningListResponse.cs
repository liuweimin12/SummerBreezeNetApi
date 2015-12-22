using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_integral_game_winning_list_response")]
    public class FindIntegralGameWinningListResponse : YunResponse, IPageResponse
    {
        [XmlArray("integral_game_winnings")]
        [XmlArrayItem("integral_game_winning")]
        public List<IntegralGameWinning> IntegralGameWinnings { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}