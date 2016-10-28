using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    /// <summary>
    /// 获取用户签到统计的返回结果
    /// </summary>
    [XmlRoot("get_user_sign_in_statistics_response")]
    public class GetUserSignInStatisticsResponse : YunResponse
    {
        /// <summary>
        /// 签到统计
        /// </summary>
        [XmlElement("sign_in_statistics")]
        public SignInStatistics SignInStatistics { get; set; }
    }
}
