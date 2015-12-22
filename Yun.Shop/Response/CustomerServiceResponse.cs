using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class CustomerServiceResponse : YunResponse
    {
        /// <summary>
        /// 返回客服列表
        /// </summary>
        [XmlElement("customer_service")]
        public CustomerServiceDetail CustomerService { get; set; }
    }
}
