using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    public class AddAlumbsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 图片类型,开发者自己标识
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 物件ID
        /// </summary>
        public int ObjectId { get; set; }



        public string GetApiName()
        {
            return "chenggou.user.alumbs.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"type",Type},
                {"objectid",ObjectId}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
