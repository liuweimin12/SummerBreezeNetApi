using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 更新自定义回复规则
    /// </summary>
    public class UpdateWxCustomApiRequest:ITopRequest<BoolResultResponse>
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
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }


        /// <summary>
        ///提交的UserApi数据，json格式
        /// </summary>
        public string RemoteUrl { get; set; }

        /// <summary>
        /// 默认回复的文字
        /// </summary>
        public string DefaultText { get; set; }

        /// <summary>
        /// access_token
        /// 与目标平台接入设置值一致，必须为英文或者数字，长度为3到32个字符.
        /// </summary>
        public string AccessToken { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.customapireply.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"disabled",Disabled},
                {"sort",Sort},
                {"keywords", WxTools.TryGetKeywords(Keywords)},
                {"ruleid",RuleId},
                {"remoteurl",RemoteUrl},
                {"defaultText",DefaultText},
                {"accesstoken",AccessToken}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("keywords", Keywords);
            RequestValidator.ValidateRequired("remoteurl", RemoteUrl);
        }
    }
}
