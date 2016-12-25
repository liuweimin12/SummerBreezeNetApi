using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 删除奖池中的奖品记录
    /// yun.game.lotteryrule.award.delete
    /// </summary>
    public class DeleteLotteryAwardRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 需要删除的领奖记录ID
        /// </summary>
        public string Ids { get; set; }


        /// <summary>
        /// 强制删除，默认不删除已经中奖的信息
        /// </summary>
        public bool ForcedDeletion { get; set; }


        public string GetApiName()
        {
            return "yun.game.lotteryrule.award.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids", Ids},
                {"forceddeletion", ForcedDeletion}
            };

            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
