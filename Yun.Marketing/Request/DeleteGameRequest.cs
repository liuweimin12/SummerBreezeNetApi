using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除游戏，同时会删除该游戏所匹配的规则
    /// chenggou.game.delete
    /// </summary>
    public class DeleteGameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.game.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
