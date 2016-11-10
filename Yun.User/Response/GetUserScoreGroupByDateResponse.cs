using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    /// <summary>
    /// 获取用户的积分记录，按日分组
    /// </summary>
    [XmlRoot("get_user_score_group_by_date_response")]
    public class GetUserScoreGroupByDateResponse : YunResponse
    {
        [XmlArray("credit_by_day_list")]
        [XmlArrayItem("credit_by_day")]
        public List<CreditByDay> CreditByDay { get; set; }
    }
}
