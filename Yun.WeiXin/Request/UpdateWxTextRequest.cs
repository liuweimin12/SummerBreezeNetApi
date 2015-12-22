using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 更新文字回复
    /// </summary>
    public class UpdateWxTextRequest:ITopRequest<BoolResultResponse>
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
        /// 回复的文字内容，使用json格式，数组
        /// </summary>
        public List<string> Content { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.textreply.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"disabled",Disabled},
                {"sort",Sort},
                {"keywords", WxTools.TryGetKeywords(Keywords)},
                {"content",Content},
                {"ruleid",RuleId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("content", Content);
            RequestValidator.ValidateRequired("keywords", Keywords);
        }
    }
}
