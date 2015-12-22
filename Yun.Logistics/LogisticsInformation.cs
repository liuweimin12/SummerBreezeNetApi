using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class LogisticsInformation
    {
        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("nu")]
        public string Nu { get; set; }

        /// <summary>
        /// 快递代码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 快递中文名字
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 走单记录
        /// </summary>
        [XmlArray("logistics_datas")]
        [XmlArrayItem("logistics_data")]
        public List<LogisticsInformationContent> LogisticsDatas { get; set; }
    }
}
