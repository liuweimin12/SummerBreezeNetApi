using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Site.Response
{
    public class ModuleTypesResponse : YunResponse
    {
        [XmlArray("modules")]
        [XmlArrayItem("module")]
        public List<StringKeyValuePair> Modules { get; set; }
    }
}
