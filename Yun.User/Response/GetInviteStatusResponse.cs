using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_invite_status_response")]
    public class GetInviteStatusResponse : YunResponse
    {
        [XmlArray("invite_statuses")]
        [XmlArrayItem("invite_status")]
        public List<InviteStatus> InviteStatuses { get; set; }
    }
}
