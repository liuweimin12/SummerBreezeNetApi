using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.User.Response
{
    public class GetSourcesOfExpenditureResponse : YunResponse
    {
        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

        /// <summary>
        /// 收入组成列表
        /// </summary>
        [XmlArray("sources_of_expenditures")]
        [XmlArrayItem("sources_of_expenditures")]
        public List<SourcesOfExpenditure> SourcesOfExpenditures { get; set; }
    }
}
