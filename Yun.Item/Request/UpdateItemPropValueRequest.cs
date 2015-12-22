using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateItemPropValueRequest : ITopUploadRequest<BoolResultResponse>, IUploadInEditState
    {
        /// <summary>
        /// 属性值ID
        /// </summary>
        public int PropValueId { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }


        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool IsHide { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propvalue.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"propvalueid", PropValueId},
                {"value", Name},
                {"sort",Sort},
                {"ishide", IsHide},
                {"image", Image}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propvalueid", PropValueId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 200);
        }

        public string Image { get; set; }
        public FileItem NewImage { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "NewImage", NewImage } };
        }
    }
}
