using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Trade.Response
{
    [XmlRoot("get_confirm_receipt_setting_response")]
    public class GetConfirmReceiptSettingResponse : YunResponse
    {
        [XmlElement("setting")]
        public SettingContent Setting { get; set; }
    }
}
