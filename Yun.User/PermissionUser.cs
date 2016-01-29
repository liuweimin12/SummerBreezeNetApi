using System.Xml.Serialization;

namespace Yun.User
{
    public class PermissionUser
    {
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
        /// 显示名字
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 角色名字
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 是否被禁用
        /// </summary>
        [XmlElement("is_disabled")]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [XmlElement("last_login_time")]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [XmlElement("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// 组织机构名字
        /// </summary>
        [XmlElement("organization_name")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// 组织机构ID
        /// </summary>
        [XmlElement("organization_id")]
        public int OrganizationId { get; set; }

        /// <summary>
        /// 是否是女性
        /// </summary>
        [XmlElement("is_female")]
        public bool IsFemale { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [XmlElement("partner_id")]
        public int PartnerId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 上级的用户ID
        /// </summary>
        [XmlElement("higher_user_id")]
        public int HigherUserId { get; set; }

        /// <summary>
        /// 职位ID
        /// </summary>
        [XmlElement("job_id")]
        public int JobId { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        [XmlElement("entry_time")]
        public string EntryTime { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("job_num")]
        public string JobNum { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [XmlElement("other_name")]
        public string OtherName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 原先的Plane改为了Telephone，座机
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 工作场所
        /// </summary>
        [XmlElement("workplace")]
        public string WorkPlace { get; set; }
    }
}
