using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    public class DeleteAlumbsRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 图片IDS，多个用英文逗号进行分割
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 类型标识符，可为空，如果存在，则删除某类别下的图片
        /// </summary>
        public int? Type { get; set; }

        /// <summary>
        /// 物件ID
        /// </summary>
        public int? ObjectId { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.alumbs.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids",Ids},
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
