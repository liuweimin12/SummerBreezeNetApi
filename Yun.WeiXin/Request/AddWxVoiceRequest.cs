using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 新增语音回复
    /// </summary>
    public class AddWxVoiceRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 规则名字
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 是否禁用
        /// </summary>
        public int Disabled { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 触发关键子，具体格式按照：关键子^规则,关键子^规则
        /// </summary>
        public IList<KeyValuePair<TriggerTypeEnum, string>> Keywords { get; set; }

        /// <summary>
        /// 微信账号ID
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 待添加的音频json信息
        /// </summary>
        public List<VoiceJsonModel> VoiceJson { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.voicereply.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"disabled",Disabled},
                {"sort",Sort},
                {"keywords", WxTools.TryGetKeywords(Keywords)},
                {"accountid",AccountId},
                {"voicejson",VoiceJson}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("keywords", Keywords);
            RequestValidator.ValidateRequired("voicejson", VoiceJson);
        }
    }
}
