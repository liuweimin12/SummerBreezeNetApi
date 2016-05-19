using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 删除商品留言
    /// </summary>
    public class DeleteItemQuestionRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 留言的id，多个ID用英文逗号分割
        /// </summary>
        public string Ids { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.question.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids", Ids}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
            RequestValidator.ValidateMaxLength("ids", this.Ids,2000);
        }
    }
}
