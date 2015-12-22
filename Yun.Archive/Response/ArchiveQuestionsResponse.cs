using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    [XmlRoot("get_archive_questions_response")]
    public class ArchiveQuestionsResponse:YunResponse
    {
        [XmlArray("questions")]
        [XmlArrayItem("question")]
        public List<ArchiveAsk> Questions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
