using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取单挑预定记录
    /// chenggou.item.book.get
    /// </summary>
    public class GetItemBookRequest : ITopRequest<GetItemBookResponse>
    {
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.item.book.get";
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
