using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class AlbumsResponse : YunResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlArray("albums")]
        [XmlArrayItem("album")]
        public List<AlbumDetail> Albums { get; set; }
    }
}
