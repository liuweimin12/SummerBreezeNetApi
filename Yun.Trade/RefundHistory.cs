
using System.Xml.Serialization;

namespace Yun.Trade
{
    public class RefundHistory
    {
        /// <summary>
        /// 凭证照片
        /// </summary>
        [XmlElement("images")]
        public string Images { get; set; }

        /// <summary>
        /// 历史记录编号
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 留言
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人昵称
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 增加记录时的退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    
    }
}
