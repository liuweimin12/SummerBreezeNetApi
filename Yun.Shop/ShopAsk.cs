using System.Xml.Serialization;
namespace Yun.Shop
{
    public class ShopAsk
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 商品ID 
        /// </summary>
        [XmlElement("object_id")]
        public long ObjectId { get; set; } 

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户的提交内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 商家的回复内容
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户备注
        /// </summary>
        [XmlElement("user_remark")]
        public string UserRemark { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        [XmlElement("reply_time")]
        public string ReplyTime { get; set; }

        /// <summary>
        /// 回复用户姓名
        /// </summary>
        [XmlElement("reply_user_name")]
        public string ReplyUserName { get; set; }
    }
}
