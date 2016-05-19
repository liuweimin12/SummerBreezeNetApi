using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 新增商品SPU的值
    /// </summary>
    public class AddItemPropValueRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 商品属性名ID
        /// </summary>
        public int PropNameId { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// 父属性值id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool IsHide { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propvalue.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"propnameid", PropNameId},
                {"value", Value},
                {"parentid", ParentId},
                {"sort", Sort},
                {"ishide", IsHide},
                {"thumb",Thumb }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propnameid", PropNameId);
            RequestValidator.ValidateRequired("value", Value);
            RequestValidator.ValidateMaxLength("value", this.Value, 200);
        }

        /// <summary>
        /// 文章的缩略图，可多张
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string Thumb { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem>
            {
                {"Image", Image}
            };
        }
    }
}
