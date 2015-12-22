using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Archive.Request
{
    public class IncreaseVisitRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 增加的浏览量
        /// </summary>
        public int Visits { get; set; }


        public string GetApiName()
        {
            return "chenggou.archive.visit.increase";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"visits",Visits}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
