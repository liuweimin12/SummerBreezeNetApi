using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 批量添加充值卡
    /// chenggou.prepaidcard.batchadd
    /// </summary>
    public class BatchAddPrepaidCardRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }


        /// <summary>
        /// 批量添加的卡数据
        /// </summary>
        public List<BatchAddCardJson> BatchAddCardJson { get; set; }


        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        public string GetApiName()
        {
            return "chenggou.prepaidcard.batchadd";
        }

        public IDictionary<string, string> GetParameters()
        {
            if (BatchAddCardJson != null && BatchAddCardJson.Any())
            {
                for (var i = 0; i < BatchAddCardJson.Count; i++)
                {
                    BatchAddCardJson[i].card_password = TopUtils.EncryptAes(BatchAddCardJson[i].card_password, AppSecret);
                }
            }

            var parameters = new YunDictionary
            {
                {"prepaidcardtypeid",PrepaidCardTypeId},
                {"batchaddcardjson",BatchAddCardJson}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("prepaidcardtypeId", PrepaidCardTypeId);
            RequestValidator.ValidateRequired("batchaddcardjson", BatchAddCardJson);
        }
    }
}
