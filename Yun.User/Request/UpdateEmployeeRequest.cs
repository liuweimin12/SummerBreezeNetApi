using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateEmployeeRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// Ip地址
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        public int HigherUserId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 职位ID
        /// </summary>
        public int JobId { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string  IdCard { get; set; }

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
        /// 是否是女性
        /// </summary>
        public bool IsFemale { get; set; }

        /// <summary>
        /// 角色ID，多个用英文逗号分隔
        /// </summary>
        public string RoleIds { get; set; }


        public int OrganizationId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.organization.user.update";
        }

        public int UserId { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ip", Ip},
                {"displayname",DisplayName},
                {"higheruserid",HigherUserId},
                {"description",Description},
                {"jobid",JobId},
                {"idcard",IdCard},
                {"entrytime",EntryTime},
                {"jobnum",JobNum},
                {"othername",OtherName},
                {"phone",Phone},
                {"email",Email},
                {"plane",Plane},
                {"workplace",WorkPlace},
                {"isfemale",IsFemale},
                {"roleids",RoleIds},
                {"userid",UserId},
                {"organizationid",OrganizationId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("userid", UserId);
        }
    }
}
