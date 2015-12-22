using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_games_response")]
    public class FindGamesResponse : YunResponse, IPageResponse
    {
        /// <summary>
        /// 游戏
        /// </summary>
        [XmlArray("game_contents")]
        [XmlArrayItem("game_content")]
        public List<Game> GameContents { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
