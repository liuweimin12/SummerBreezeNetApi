using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Pay.Response
{
    public class GetDefaultPayMentRateResponse:YunResponse
    {
        /// <summary>
        /// 返回站点对下家的默认在线支付抽成比例
        /// </summary>
        [XmlElement("result")]
        public OnlinePayRate Result { get; set; }
    }
}
