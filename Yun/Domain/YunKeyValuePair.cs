using System.Xml.Serialization;

namespace Yun.Domain
{
    public class YunKeyValuePair<T, V>
    {
        public YunKeyValuePair()
        {

        }

        public YunKeyValuePair(T key, V value)
        {
            Key = key;
            Value = value;
        }

        [XmlElement("key")]
        public T Key { get; set; }

        [XmlElement("value")]
        public V Value { get; set; }
    }
}
