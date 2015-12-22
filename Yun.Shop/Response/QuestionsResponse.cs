using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class QuestionsResponse : YunResponse, IPageResponse
    {
        /// <summary>
        /// 问题列表
        /// </summary>
        [XmlArray("questions")]
        [XmlArrayItem("question")]
        public List<ShopAsk> Questions { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

    }
}
