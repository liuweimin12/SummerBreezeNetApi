using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_email_setting_response")]
    public class GetEmailSettingResponse:YunResponse
    {
        [XmlElement("email_setting")]
        public EmailSetting EmailSetting { get; set; }
    }
}
