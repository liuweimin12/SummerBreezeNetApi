using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class UserDetailResponse : YunResponse 
    {
        [XmlElement("employee")]
        public Employee User { get; set; }
    }
}
