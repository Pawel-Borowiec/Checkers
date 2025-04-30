namespace Checkers.Services;

public interface ILogservice
{
    public  void Log(string message);
    public List<string> GetLogs();
}