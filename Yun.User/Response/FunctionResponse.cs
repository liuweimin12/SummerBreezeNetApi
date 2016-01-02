using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class FunctionResponse : YunResponse
    {
        /// <summary>
        /// 功能详情
        /// </summary>
        [XmlElement("function")]
        public Function Function { get; set; }
    }
}
