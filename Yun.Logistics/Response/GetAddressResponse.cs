using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    public class GetAddressResponse : YunResponse
    {
        /// <summary>
        /// 返回某用户的所有地址记录信息
        /// </summary>
        [XmlElement("address")]
        public UserAddress Result { get; set; }
    }
}
