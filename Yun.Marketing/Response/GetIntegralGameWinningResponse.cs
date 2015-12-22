using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    /// <summary>
    /// 获取积分游戏的单条获奖信息
    /// </summary>
    [XmlRoot("get_integral_game_winning_response")]
    public class GetIntegralGameWinningResponse: YunResponse
    {
        /// <summary>
        /// 积分游戏的单条获奖信息
        /// </summary>
        [XmlElement("integral_game_winning")]
        public IntegralGameWinning IntegralGameWinning { get; set; }
    }
}
