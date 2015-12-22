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
    /// 修改商品预定的状态
    /// chenggou.item.book.modifystatus
    /// </summary>
    public class ChangeBookStatusRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        /// <summary>
        /// 状态，可以自定义状态
        /// </summary>
        public int Status { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.book.modifystatus";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"status",Status}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
