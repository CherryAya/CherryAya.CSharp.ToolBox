using System;

namespace CherryAya.CSharp.ToolBox.Logger
{
    public interface ILoggerService
    {
        public bool Debug(object from, object type, object message);
        public bool Info(object from, object type, object message);
        public bool Warn(object from, object type, object message);
        public bool Exception(object from, object type, object message);
        public bool Fatal(object from, object type, object message);
        public bool UnhandledException(UnhandledExceptionEventArgs args);
    }
}
