using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Archive
{
    public class ArticleDetail
    {
        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("post_datetime")]
        public string  PostDateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_datetime")]
        public string ModifyDateTime { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [XmlElement("id")]
        public long  Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string  CreateTime { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [XmlElement("thumb")]
        public string Thumb { get; set; }


        /// <summary>
        /// 访问数
        /// </summary>
        [XmlElement("visits")]
        public long  Visits { get; set; }

        /// <summary>
        /// 当前文章所述分类
        /// </summary>
        [XmlArray("categorys")]
        [XmlArrayItem("category")]
        public List<LongKeyValuePair> Categorys { get; set; }

        /// <summary>
        /// 当前文章拥有标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("tag")]
        public List<LongKeyValuePair> Tags { get; set; }

        /// <summary>
        /// 发布者用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long  UserId { get; set; }

        /// <summary>
        /// 发布人用户名
        /// </summary>
        [XmlElement("username")]
        public string UserName { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [XmlElement("site_id")]
        public long SiteId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 下一篇文章
        /// </summary>
        [XmlElement("next_article")]
        public LongKeyValuePair NextArticle { get; set; }

        /// <summary>
        /// 上一篇文章
        /// </summary>
        [XmlElement("prev_article")]
        public LongKeyValuePair PrevArticle { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        [XmlArray("post_metas")]
        [XmlArrayItem("post_meta")]
        public List<StringKeyValuePair> PostMeta { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
