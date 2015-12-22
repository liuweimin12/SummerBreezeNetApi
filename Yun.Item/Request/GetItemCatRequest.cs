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
    /// 获取全局类目信息
    /// chenggou.itemcat.get
    /// </summary>
    public class GetItemCatRequest : ITopRequest<GetItemCatResponse>
     {
        public int Id { get; set; }

         public string GetApiName()
         {
             return "chenggou.itemcat.get";
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
