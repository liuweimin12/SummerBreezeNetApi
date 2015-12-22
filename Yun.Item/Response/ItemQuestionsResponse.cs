using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class  ItemQuestionsResponse : YunResponse, IPageResponse
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        [XmlArray("questions")]
        [XmlArrayItem("question")]
        public List<ItemAsk> Questions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
