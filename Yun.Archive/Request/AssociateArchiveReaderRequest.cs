using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Archive.Request
{
    /// <summary>
    /// 关联文章的授权越都对象
    /// 需要授权
    /// </summary>
    public class AssociateArchiveReaderRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 文章id
        /// </summary>
        public int ArchiveId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 用户ID，多个用英文逗号进行分割
        /// </summary>
        public string UserIds { get; set; }


        public string GetApiName()
        {
            return "chenggou.archive.reader.associate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"archiveid",ArchiveId},
                {"type",Type},
                {"userids",UserIds}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("archiveid", ArchiveId, 1);

        }
    }
}
