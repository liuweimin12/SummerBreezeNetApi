
using System.Xml.Serialization;
namespace Yun.Item
{
    public class ItemAsk
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评论
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户评论
        /// </summary>
        [XmlElement("user_remark")]
        public string UserRemark { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        [XmlElement("reply_time")]
        public string ReplyTime { get; set; }

        /// <summary>
        /// 回复的用户名
        /// </summary>
        [XmlElement("reply_user_name")]
        public string ReplyUserName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }
    }
}
