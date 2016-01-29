using System.Xml.Serialization;

namespace Yun.User
{
    public class PermissionUser
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        [XmlElement("is_disabled")]
        public bool IsDisabled { get; set; }


        /// <summary>
        /// 最后登录时间
        /// </summary>
        [XmlElement("last_login_time")]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [XmlElement("creator_id")]
        public long CreatorId { get; set; }


        /// <summary>
        /// 组织名称
        /// </summary>
        [XmlElement("organization_name")]
        public string OrganizationName { get; set; }

        /// <summary>
        /// 组织id
        /// </summary>
        [XmlElement("organization_id")]
        public long OrganizationId { get; set; }

        /// <summary>
        /// 是否是女性
        /// </summary>
        [XmlElement("is_female")]
        public bool IsFemale { get; set; }

        /// <summary>
        /// 合作伙伴ID
        /// </summary>
        [XmlElement("partner_id")]
        public long PartnerId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }


        /// <summary>
        /// 更高的用户ID
        /// </summary>
        [XmlElement("higher_user_id")]
        public long HigherUserId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
       [XmlElement("job_id")]
        public long JobId { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 进入时间
        /// </summary>
        [XmlElement("entry_time")]
        public string EntryTime { get; set; }

        /// <summary>
        /// 工作数量
        /// </summary>
        [XmlElement("job_num")]
        public string JobNum { get; set; }

        /// <summary>
        /// 其他名称
        /// </summary>
        [XmlElement("other_name")]
        public string OtherName { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 座机
        /// </summary>
        [XmlElement("telephone")]
        public string Plane { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        [XmlElement("workplace")]
        public string WorkPlace { get; set; }
    }
}
