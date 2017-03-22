using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("getmutiple_user_signin_statistics_response")]
    public class GetmutipleUserSignInStatisticsResponse : YunResponse
    {
        [XmlArray("signin_statistics")]
        [XmlArrayItem("signin_statistic")]
        public List<SignStatisticsModel> SignInStatistics { get; set; }
    }
}
