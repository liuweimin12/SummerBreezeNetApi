using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Archive.Response
{
    [XmlRoot("get_archive_question_response")]
    public class GetArchiveQuestionResponse:YunResponse
    {
        [XmlElement("question")]
        public ArchiveAsk Question { get; set; }
    }
}
