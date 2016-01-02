using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    public class GetWxAccountResponse : YunResponse
    {
        [XmlElement("account")]
        public AccountDomain Account { get; set; }
    }
}
