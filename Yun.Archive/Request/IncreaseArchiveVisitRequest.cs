using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 增加浏览量
    /// 根据文章ID增加对应文章的浏览量
    /// </summary>
    public class IncreaseArchiveVisitRequest : ITopRequest<BoolResultResponse>
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
