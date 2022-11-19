using Application.Common.Interfaces;
using NLog;

namespace Infrastructure.Services;

public class LogManager : ILoggerManager
{
    private static ILogger _logger = NLog.LogManager.GetCurrentClassLogger();
    public LogManager()
    {
        
    }

    public void LogInfo(string message) => _logger.Info(message);


    public void LogWarn(string message) => _logger.Warn(message);


    public void LogDebug(string message) => _logger.Debug(message);


    public void LogError(string message) => _logger.Error(message);

}