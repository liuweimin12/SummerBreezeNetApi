using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.WeiXin
{
    public class CustomMenuButton
    {
        /// <summary>
        /// 自定义菜单名字
        /// </summary>
        [XmlElement("name")]
        public string name { get; set; }


        /// <summary>
        /// 菜单类型
        /// </summary>
        [XmlElement("menu_type")]
        public string menu_type { get; set; }


        /// <summary>
        /// 键值
        /// </summary>
        [XmlElement("key")]
        public string key { get; set; }


        /// <summary>
        /// 网址
        /// </summary>
        [XmlElement("url")]
        public string url { get; set; }


        /// <summary>
        /// 子菜单
        /// </summary>
        [XmlArray("sub_menus")]
        [XmlArrayItem("sub_menu")]
        public List<CustomMenuButton> sub_menu { get; set; }
    }
}
