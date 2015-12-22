using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.WeiXin.Response
{
    public class GetMediaIdResponse:YunResponse
    {
        [XmlElement("media")]
        public UploadResult Media { get; set; }
    }
}
