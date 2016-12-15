using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Logistics.Response
{
    /// <summary>
    /// 获取常用快递
    /// </summary>
    [XmlRoot("get_commonly_used_express_response")]
    public class GetCommonlyUsedExpressResponse : YunResponse
    {
        [XmlArray("commonly_used_expresses")]
        [XmlArrayItem("commonly_used_express__list")]
        public List<CommonlyUsedExpress> CommonlyUsedExpress { get; set; }
    }
}
