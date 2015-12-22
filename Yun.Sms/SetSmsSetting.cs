

using System.Xml.Serialization;
namespace Yun.Sms
{
    public class SetSmsSetting
    {
        [XmlElement("service_id")]
        public long ServiceId { get; set; }

        [XmlElement("auth")]
        public string Auth { get; set; }

        [XmlElement("is_select")]
        public bool IsSelect { get; set; }
    }
}
