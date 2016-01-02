using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_score_list_response")]
    public class GetUserScoreListResponse : YunResponse
    {
        [XmlArray("credits")]
        [XmlArrayItem("credit")]
        public List<CreditDomain> Credits { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
