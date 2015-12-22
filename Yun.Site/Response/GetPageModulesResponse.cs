using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Site.Response
{
    public class GetPageModulesResponse : YunResponse
    {
        /// <summary>
        /// 返回具体数据列表
        /// </summary>
        [XmlArray("modules")]
        [XmlArrayItem("module")]
        public List<SiteModule> Modules { get; set; }
    }
}
