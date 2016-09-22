
using System.Xml.Serialization;

namespace Yun.Domain
{
    public class UserAssociation
    {
        /// <summary>
        /// 收藏店铺的时间
        /// </summary>
        [XmlElement("collected_time")]
        public string CollectedTime { get; set; }
    }
}
