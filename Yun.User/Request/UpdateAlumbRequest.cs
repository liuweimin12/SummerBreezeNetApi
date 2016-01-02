using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateAlumbRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 图片ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 是否对外显示
        /// </summary>
        public bool Display { get; set; }


        /// <summary>
        /// 原图片URL
        /// </summary>
        public string ImageUrl { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.alumb.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"display",Display},
                {"imageurl",ImageUrl}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("display", Display);
        }
    }
}
