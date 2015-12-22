using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Site.Response
{
    public class PagesResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("pages")]
        [XmlArrayItem("page")]
        public List<SitePage> Pages { get; set; }
         
    }
}
