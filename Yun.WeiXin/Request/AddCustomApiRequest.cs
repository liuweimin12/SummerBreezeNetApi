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
    /// 新增自定义回复
    /// </summary>
    public class AddCustomApiRequest:ITopRequest<IntResultResponse>
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
        /// 回复的文字内容，标题^描述,标题^描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 微信账号ID
        /// </summary>
        public int AccountId { get; set; }

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
            return "chenggou.weixin.customapireply.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"disabled",Disabled},
                {"sort",Sort},
                {"keywords",WxTools.TryGetKeywords(Keywords)},
                {"description",Description},
                {"title",Title},
                {"accountid",AccountId},
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
