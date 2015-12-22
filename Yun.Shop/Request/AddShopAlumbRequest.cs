using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class AddShopAlumbRequest : ITopUploadRequest<BoolResultResponse>
    {
        /// <summary>
        /// 店铺照片
        /// </summary>
        public IList<FileItem> Image { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            var r = new Dictionary<string, FileItem>();
            if (Image == null) return r;

            foreach (var fileItem in Image.Where(fileItem => !r.ContainsKey(fileItem.GetFileName())))
            {
                r.Add(fileItem.GetFileName(), fileItem);
            }

            return r;
        }

        public string GetApiName()
        {
            return "chenggou.shop.alumb.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary();
        }

        public void Validate()
        {
        }
    }
}
