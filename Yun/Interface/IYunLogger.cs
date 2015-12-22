namespace Yun.Interface
{
    /// <summary>
    /// 日志打点接口。
    /// </summary>
    public interface IYunLogger
    {
        void Error(string message);
        void Warn(string message);
        void Info(string message);
    }
}
