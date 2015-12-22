using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Response
{
    /// <summary>
    /// 需要被删除，无法使用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TRSingleResponse<T> : ChengResponse
    {
        [XmlArray("result")]
        [XmlArrayItem("result")]
        public T Result { get; set; }
    }
}
