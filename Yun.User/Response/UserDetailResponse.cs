using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    [XmlRoot("get_employee_response")]
    public class UserDetailResponse : YunResponse 
    {
        [XmlElement("employee")]
        public Employee User { get; set; }
    }
}
