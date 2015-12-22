using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    [XmlRoot("get_band_banks_response")]
    public class GetBandBanksResponse : YunResponse
    {
        [XmlArray("banks")]
        [XmlArrayItem("bank")]
        public List<Bank> Banks { get; set; }
    }
}
