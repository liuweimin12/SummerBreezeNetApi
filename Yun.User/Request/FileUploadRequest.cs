using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class FileUploadRequest : ITopUploadRequest<FileResultResponse>
    {
        /// <summary>
        /// 远程文件路径
        /// 根据传入的远程图片路径自动下载文件
        /// </summary>
        public string RemoteFileUrl { get; set; }

        public string GetApiName()
        {
            return "chenggou.file.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary();
            parameters.Add("remotefileurl", RemoteFileUrl);

            return parameters;
        }

        public void Validate()
        {

        }

        public IList<FileItem> Images { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            var r = new Dictionary<string, FileItem>();
            if (Images != null && Images.Any())
            {
                foreach (var fileItem in Images)
                {
                    r.Add(fileItem.GetFileName(), fileItem);
                }

            }

            return r;
        }
    }
}
