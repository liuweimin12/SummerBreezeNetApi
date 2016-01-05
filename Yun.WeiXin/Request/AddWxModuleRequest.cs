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
    /// 新增模块
    /// </summary>
    public class AddWxModuleRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 模块的标识，全局唯一，只允许英文，和程序集名字对应
        /// </summary>
        public string Identifie { get; set; }

        /// <summary>
        /// 模块的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 订阅的消息类型，多个用英文逗号分隔
        /// </summary>
        public string Subscribes { get; set; }


        /// <summary>
        /// 执行的消息类型，多个用英文逗号分隔
        /// </summary>
        public string Handles { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.module.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"identifie",Identifie},
                {"name",Name},
                {"subscribes",Subscribes},
                {"handles",Handles}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("identifie", Identifie);
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
