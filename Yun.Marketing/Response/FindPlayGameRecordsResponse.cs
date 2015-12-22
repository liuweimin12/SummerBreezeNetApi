using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("find_play_game_records_response")]
    public class FindPlayGameRecordsResponse : YunResponse, IPageResponse
    {
        [XmlElement("total_item")]
        public long TotalItem { get; set; }

        /// <summary>
        /// 游戏
        /// </summary>
        [XmlArray("play_game_records")]
        [XmlArrayItem("play_game_record")]
        public List<PlayGameRecord> PlayGameRecords { get; set; }
    }
}
