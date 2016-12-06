using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class AddEmployeeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Ip地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string DisplayName{get;set;}

        /// <summary>
        /// 上级ID
        /// </summary>
        public int HigherUserId { get; set; }

        /// <summary>
        /// 职位ID
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard { get; set; }

        /// <summary>
        /// 入职时间
        /// </summary>
        public string EntryTime { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }

        /// <summary>
        /// 花名
        /// </summary>
        public string OtherName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 座机
        /// </summary>
        public string Plane { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        public string WorkPlace { get; set; }

        /// <summary>
        /// 组织机构ID
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// 是否是女性
        /// </summary>
        public bool IsFemale { get; set; }

        /// <summary>
        /// 角色ID，多个用英文逗号分隔
        /// </summary>
        public string RoleIds { get; set; }
        
        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.user.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username", UserName},
                {"password", TopUtils.EncryptAes(Password, AppSecret)},
                {"ip",Ip},
                {"description",Description},
                {"displayname",DisplayName},
                {"higheruserid",HigherUserId},
                {"jobid",JobId},
                {"idcard",IdCard},
                {"entrytime",EntryTime},
                {"jobnum",JobNum},
                {"othername",OtherName},
                {"phone",Phone},
                {"email",Email},
                {"plane",Plane},
                {"workplace",WorkPlace},
                {"organizationid",OrganizationId},
                {"isfemale",IsFemale},
                {"roleids",RoleIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username",UserName);
            RequestValidator.ValidateMaxLength("username", UserName, 30);
            RequestValidator.ValidateRequired("password", Password);
            RequestValidator.ValidateRequired("appsecret", AppSecret);
        }
    }
}
