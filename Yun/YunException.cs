using System;
using System.Runtime.Serialization;

namespace Yun
{
    /// <summary>
    /// TOP客户端异常。
    /// </summary>
    public class YunException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public YunException()
            : base()
        {
        }

        public YunException(string message)
            : base(message)
        {
        }

        protected YunException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public YunException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public YunException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
