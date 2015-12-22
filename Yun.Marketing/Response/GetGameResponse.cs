using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_game_response")]
    public class GetGameResponse: YunResponse
    {
        /// <summary>
        /// 游戏总则
        /// </summary>
        [XmlElement("game_content")]
        public Game GameContent { get; set; }
    }
}
