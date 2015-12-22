//using Framework.Utility.Logging;

using Yun.Interface;

namespace Yun
{
    /// <summary>
    /// 日志打点的简单实现。
    /// </summary>
    public class DefaultYunLogger : IYunLogger
    {
        //private static readonly EmailLog _log = new EmailLog(typeof(DefaultTopLogger));

        public void Error(string message)
        {
            //_log.Error(message);
        }

        public void Warn(string message)
        {
           // _log.Warn(message);
        }

        public void Info(string message)
        {
           // _log.Info(message);
        }
    }
}
