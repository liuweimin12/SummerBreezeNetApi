using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_band_bank_response")]
    public class GetBandBankResponse : YunResponse
    {
        [XmlElement("bank")]
        public Bank Bank { get; set; }
    }
}
