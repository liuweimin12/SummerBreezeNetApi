using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 上传用户头像并修改
    /// </summary>
    public class UploadAvatarUserRequest:ITopUploadRequest<ModifyAvatarResponse>
    {
        /// <summary>
        /// 上传头像
        /// </summary>
        public FileItem Image { get; set; }

        public IDictionary<string, Util.FileItem> GetFileParameters()
        {
            return  new  Dictionary<string, FileItem>
            {
                {"Image",Image}
            };
        }

        public string GetApiName()
        {
            return "chenggou.user.avatar.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary();
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
