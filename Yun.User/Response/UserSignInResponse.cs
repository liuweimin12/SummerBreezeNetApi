using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("user_sign_in_response")]
    public class UserSignInResponse : YunResponse
    {
        /// <summary>
        /// 下次签到获取积分
        /// </summary>
        [XmlElement("next_sign_in")]
        public int NextSignIn { get; set; }


        /// <summary>
        /// 当前签到获得积分
        /// </summary>
        [XmlElement("current_sign_in")]
        public int CurrentSignIn { get; set; }


        /// <summary>
        /// 连续签到时间
        /// </summary>
        [XmlElement("continue_day")]
        public int ContinueDay { get; set; }
    }
}
