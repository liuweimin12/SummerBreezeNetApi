using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.User.Response
{
    public class GetAlbumResponse: YunResponse
    {
        /// <summary>
        /// 相片
        /// </summary>
        [XmlArray("albums")]
        [XmlArrayItem("album")]
        public List<AlbumDetail> Items { get; set; }

        [XmlElement("totalitem")]
        public long TotalItem { get; set; }
    }
}
