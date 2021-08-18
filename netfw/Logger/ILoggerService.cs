using System;

namespace CherryAya.CSharp.ToolBox.netfw.Logger
{
    public interface ILoggerService
    {
        bool Debug(object from, object type, object message);
        bool Info(object from, object type, object message);
        bool Warn(object from, object type, object message);
        bool Exception(object from, object type, object message);
        bool Fatal(object from, object type, object message);
        bool UnhandledException(UnhandledExceptionEventArgs args);
    }
}
