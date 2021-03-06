﻿using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class CategoriesResponse : YunResponse
    {
        /// <summary>
        /// 返回具体信息
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("category")]
        public List<CommonCategory> Categories { get; set; }
    }
}
