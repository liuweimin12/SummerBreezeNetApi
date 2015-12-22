using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 删除商品的预定记录
    /// chenggou.item.book.delete
    /// </summary>
    public class DeleteItemBookRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.book.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
