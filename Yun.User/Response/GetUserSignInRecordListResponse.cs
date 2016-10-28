using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_user_sign_in_record_list_response")]
    public class GetUserSignInRecordListResponse: YunResponse
    {
        [XmlArray("sign_in_records")]
        [XmlArrayItem("sign_in_record")]
        public List<SignInHistory> SignInRecords { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
