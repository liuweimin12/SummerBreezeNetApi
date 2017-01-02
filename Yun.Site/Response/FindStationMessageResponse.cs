using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    /// <summary>
    /// 查找站点消息
    /// </summary>
    [XmlRoot("find_station_message_response")]
    public class FindStationMessageResponse: YunResponse
    {
        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

        /// <summary>
        /// 站内信息
        /// </summary>
        [XmlArray("station_messages")]
        [XmlArrayItem("station_message")]
        public List<StationMessage> StationMessages { get; set; }
    }
}
