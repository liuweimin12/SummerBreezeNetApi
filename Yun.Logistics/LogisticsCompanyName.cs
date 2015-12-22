using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class LogisticsCompanyName
    {
        /// <summary>
        /// 物流公司中文名
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }


        /// <summary>
        /// 物流公司英文名
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }
    }
}
