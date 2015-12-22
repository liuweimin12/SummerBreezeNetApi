
using System.Xml.Serialization;
namespace Yun.Response
{
    public interface IPageResponse
    {
      long TotalItem { get; set; }
    }
}
