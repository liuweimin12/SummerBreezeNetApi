using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_station_message_response")]
    public class GetStationMessageResponse: YunResponse
    {
        [XmlElement("station_message")]
        public StationMessage StationMessage { get; set; }
    }
}
