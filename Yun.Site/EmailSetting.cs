using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Site
{
    public class EmailSetting
    {
        /// <summary>
        /// SMTP主机
        /// </summary>
        [XmlElement("server")]
        public string Server { get; set; }


        /// <summary>
        /// 端口
        /// </summary>
        [XmlElement("port")]
        public int Port { get; set; }


        /// <summary>
        /// 是否使用SSL 
        /// </summary>
        [XmlElement("ssl")]
        public bool Ssl { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [XmlElement("username")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [XmlElement("password")]
        public string Password { get; set; }

        /// <summary>
        /// 发信地址
        /// </summary>
        [XmlElement("from")]
        public string From { get; set; }
    }
}
