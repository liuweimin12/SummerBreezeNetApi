using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class GetBuyPriceResponse:YunResponse
    {
        /// <summary>
        /// 返回网站出售的短信价格
        /// </summary>
        [XmlElement("sms_price")]
        public PriceSetting Result { get; set; }
    }
}
