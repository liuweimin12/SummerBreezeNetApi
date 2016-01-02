

using System.Xml.Serialization;
namespace Yun.User
{
    public class Function
    {
        /// <summary>
        /// 组织机构id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
         [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间，UNIX时间戳
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间，UNIX时间戳
        /// </summary>
         [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// Url
        /// </summary>
          [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [XmlElement("creator_id")]
        public long CreatorId { get; set; }

        /// <summary>
        /// 修改人用户名
        /// </summary>
        [XmlElement("modify_user")]
        public string ModifyUser { get; set; }


        /// <summary>
        /// 修改人用户ID
        /// </summary>
        [XmlElement("modify_user_id")]
        public long ModifyUserId { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [XmlElement("is_display")]
        public bool IsDisplay { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }


        /// <summary>
        /// 允许的权限
        /// </summary>
        [XmlElement("allow_block")]
        public string AllowBlock { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }
    }
}
