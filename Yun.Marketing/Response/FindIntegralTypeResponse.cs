using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_integral_type_response")]
    public class FindIntegralTypeResponse : YunResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }


        /// <summary>
        /// 积分类型
        /// </summary>
        [XmlArray("integral_types")]
        [XmlArrayItem("integral_type")]
        public List<IntegralType> IntegralTypes { get; set; }
    }
}
