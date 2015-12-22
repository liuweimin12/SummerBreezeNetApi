
using Yun.Util;

namespace Yun.Response
{
    public interface IUploadInEditState
    {
        string Image { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        
        FileItem NewImage { get; set; }
    }
}
