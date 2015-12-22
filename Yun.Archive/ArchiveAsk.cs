using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Archive
{
   public class ArchiveAsk
    {
       /// <summary>
       /// ID
       /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

       /// <summary>
       /// 用户ID
       /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

       /// <summary>
       /// 用户名
       /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

       /// <summary>
       /// 项目ID
       /// </summary>
        [XmlElement("item_id")]
        public int ObjectId { get; set; }

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
       /// 回复用户名
       /// </summary>
        [XmlElement("reply_username")]
        public string ReplyUserName { get; set; }

       /// <summary>
       /// 项目标题
       /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }
    }
}
