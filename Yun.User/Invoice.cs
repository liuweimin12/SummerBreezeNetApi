using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.User
{
    public class Invoice
    {
        /// <summary>
        /// 发票内容
        /// </summary>
        [XmlElement("invoice_content")]
        public string InvoiceContent { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_header")]
        public string InvoiceHeader { get; set; }
    }
}
