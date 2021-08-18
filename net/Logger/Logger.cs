using System;

namespace CherryAya.CSharp.ToolBox.Logger
{
    public static class Logger
    {
        private static LoggerLevel level = LoggerLevel.Info;
        private static ILoggerService loggerService = new defualtLoggerService();

        public static void setLoggerService(ILoggerService newLoggerService)
        {
            loggerService = newLoggerService;
        }

        public static bool setLoggerLevel(LoggerLevel level)
        {
            if (level < LoggerLevel.Debug || level > LoggerLevel.None)
            {
                loggerService.Exception("Logger", "initLoggerLevel", "LoggerLevel out of range.");
                return false;
            }
            Logger.level = level;
            return true;
        }


        public static LoggerLevel getLoggerLevel()
        {
            return level;
        }

        public static bool Debug(object from, object type, object message)
        {
            if (level > LoggerLevel.Debug)
                return false;
            loggerService.Debug(from, type, message);
            return true;
        }

        public static bool Info(object from, object type, object message)
        {
            if (level > LoggerLevel.Info)
                return false;
            loggerService.Info(from, type, message);
            return true;
        }

        public static bool Warn(object from, object type, object message)
        {
            if (level > LoggerLevel.Warn)
                return false;
            loggerService.Warn(from, type, message);
            return true;
        }

        public static bool Exception(object from, object type, object message)
        {
            if (level == LoggerLevel.None)
                return false;
            loggerService.Exception(from, type, message);
            return true;
        }

        public static bool Fatal(object from, object type, object message)
        {
            if (level == LoggerLevel.None)
                return false;
            loggerService.Fatal(from, type, message);
            return true;
        }

        public static bool UnhandledException(UnhandledExceptionEventArgs args)
        {
            if (level != LoggerLevel.None)
                return false;
            loggerService.UnhandledException(args);
            return true;
        }
    }
}
