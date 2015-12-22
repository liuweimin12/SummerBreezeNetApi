using System.Collections.Generic;
using Yun.Interface;
using Yun.Sms.Response;
using Yun.Util;

namespace Yun.Sms.Request
{
    public class FindSignatureRequest : ITopRequest<SignaturesResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;


        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;

        public bool? Enabled { get; set; }

        public bool? IsPassed { get; set; }

        public string GetApiName()
        {
            return "chenggou.sms.signatures.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"enabled",Enabled},
                {"ispassed",IsPassed},
            };
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 40);
        }
    }
}
