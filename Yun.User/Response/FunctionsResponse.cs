using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class FunctionsResponse : YunResponse
    {
        /// <summary>
        /// 功能列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function")]
        public List<Function> Functions { get; set; }
    }
}
