using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Sms.Response
{
    public class GetSettingResponse : YunResponse
    {
        /// <summary>
        /// 返回店铺文章系统分类信息
        /// </summary>
        [XmlArray("settings")]
        [XmlArrayItem("setting")]
        public List<SupportDataList> Settings { get; set; }
    }
}
