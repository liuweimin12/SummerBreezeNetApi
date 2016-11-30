using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class GetUserTotalScoreResponse : YunResponse
    {
        /// <summary>
        /// 用户的积分数据
        /// </summary>
        [XmlElement("total_points")]
        public TotalPoints TotalPoints { get; set; }
    }
}
