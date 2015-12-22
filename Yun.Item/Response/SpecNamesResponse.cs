using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Item.Response
{
    public class SpecNamesResponse : YunResponse
    {
        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("curren_tpage")]
        public long  CurrentPage { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set;}

        /// <summary>
        /// 每页包含
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 属性名列表
        /// </summary>
        [XmlArray("specnames")]
        [XmlArrayItem("specname")]
        public List<ItemSpecName> SpecNames { get; set; }
    }
}
