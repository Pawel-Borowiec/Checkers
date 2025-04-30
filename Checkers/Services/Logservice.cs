namespace Checkers.Services;

public class Logservice : ILogservice
{
    private List<string> Logs { get; set; } = new List<string>();
    

    public void Log(string message)
    {
        Logs.Add(message);
    }

    public List<string> GetLogs()
    {
        return Logs;
    }
}