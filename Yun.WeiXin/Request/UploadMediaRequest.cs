using System.Collections.Generic;
using Yun.Interface;
using Yun.Util;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 上传媒体
    /// </summary>
    public class UploadMediaRequest:ITopRequest<GetMediaIdResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.media.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"accountid",AccountId},
                {"filetype",FileType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("accountid", AccountId, 1);
            RequestValidator.ValidateRequired("filetype", FileType);
        }
    }
}
