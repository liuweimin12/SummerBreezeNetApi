using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    /// <summary>
    /// 获取公司信息
    /// </summary>
    [XmlRoot("get_company_response")]
    public class GetCompanyResponse : YunResponse
    {
        /// <summary>
        /// 公司信息
        /// </summary>
        [XmlElement("company")]
        public CompanyDomain Company { get; set; }
    }
}
