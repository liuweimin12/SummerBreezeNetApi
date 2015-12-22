using System;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class UserAddress
    {
        /// <summary>
        /// 地址id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        [XmlElement("street")]
        public string Street { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zipcode")]
        public string Zipcode { get; set; }
        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 是否默认地址，Y或者N
        /// </summary>
        [XmlElement("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string  CreateTime { get; set; }

        /// <summary>
        ///地址详情
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }
    }
}
