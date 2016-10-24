﻿using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 签到领积分
    /// yun.user.signin
    /// </summary>
    public class UserSignInRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "yun.user.signin";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
