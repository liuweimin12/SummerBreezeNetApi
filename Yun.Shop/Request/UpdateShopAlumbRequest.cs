using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class UpdateShopAlumbRequest : ITopUploadRequest<BoolResultResponse>
    {
        /// <summary>
        /// 店铺照片
        /// </summary>
        public FileItem Image { get; set; }

        public IDictionary<string, Util.FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", Image } };
        }

        public string GetApiName()
        {
            return "chenggou.shop.alumb.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"image", Image}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("image", Image);
        }
    }
}
