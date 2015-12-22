using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class GetDefaultAddressResponse : YunResponse
    {
        /// <summary>
        /// 获取某用户的默认地址
        /// </summary>
        [XmlElement("address")]
        public UserAddress Result { get; set; }
    }
}
