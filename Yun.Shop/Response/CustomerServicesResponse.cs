using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class CustomerServicesResponse : YunResponse
    {
        /// <summary>
        /// 返回客服列表
        /// </summary>
        [XmlArray("customer_services")]
        [XmlArrayItem("customer_service")]
        public List<CustomerService> CustomerServices { get; set; }
    }
}
