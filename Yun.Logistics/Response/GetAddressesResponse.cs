using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class GetAddressesResponse : YunResponse
    {
        /// <summary>
        /// 返回用户的某条地址记录
        /// </summary>
        [XmlArray("addresses")]
        [XmlArrayItem("address")]
        public List<UserAddress> Result { get; set; }
    }
}
