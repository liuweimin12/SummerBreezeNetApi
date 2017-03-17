using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_login_info_response")]
    public class GetUserLoginInfoResponse : YunResponse
    {
        [XmlArray("login_info_list")]
        [XmlArrayItem("login_info")]
        public List<LoginInfo> LoginInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
