using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    public class GetWxAccountsResponse:YunResponse
    {
        [XmlArray("accounts")]
        [XmlArrayItem("account")]
        public List<AccountDomain> Accounts { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
