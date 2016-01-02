using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;

namespace Yun.User.Request
{
    public class GetEmployeesRequest : ITopRequest<UsersRespons>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;

        public int OrganizationId { get; set; }
        public string UserName { get; set; }
        public string RealName { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.users.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"organizationid",OrganizationId},
                {"username", UserName},
                {"realname", RealName},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
