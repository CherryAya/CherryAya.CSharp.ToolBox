using System;
using System.Text;
using System.Threading;

namespace CherryAya.CSharp.ToolBox.Logger
{
    public class defualtLoggerService : ILoggerService
    {
        private static readonly object Lock = new();
        private StringBuilder builder;

        public bool Debug(object from, object type, object message)
        {
            lock (Lock)
            {
                this.Init();
                builder.Append(DateTime.Now.ToString("G") + " DEBUG --> [ ");
                builder.Append(from.ToString() + " ] ");
                builder.Append(type.ToString() + " : " + message.ToString());
                Console.WriteLine(builder.ToString());
                return true;
            }
        }

        public bool Info(object from, object type, object message)
        {
            lock (Lock)
            {
                this.Init();
                builder.Append(DateTime.Now.ToString("G") + " INFO --> [ ");
                builder.Append(from.ToString() + " ] ");
                builder.Append(type.ToString() + " : " + message);
                Console.WriteLine(builder.ToString());
                return true;
            }
        }

        public bool Warn(object from, object type, object message)
        {
            lock (Lock)
            {
                this.Init();
                builder.Append(DateTime.Now.ToString("G") + " Warn --> [ ");
                builder.Append(from.ToString() + " ] ");
                builder.Append(type.ToString() + " : " + message);
                Console.WriteLine(builder.ToString());
                return true;
            }
        }

        public bool Exception(object from, object type, object message)
        {
            lock (Lock)
            {
                this.Init();
                builder.Append(DateTime.Now.ToString("G") + " Exception --> [ ");
                builder.Append(from.ToString() + " ] ");
                builder.Append(type.ToString() + " : " + message);
                Console.WriteLine(builder.ToString());
                return true;
            }
        }

        public bool Fatal(object from, object type, object message)
        {
            lock (Lock)
            {
                this.Init();
                builder.Append(DateTime.Now.ToString("G") + " Fatal --> [ ");
                builder.Append(from.ToString() + " ] ");
                builder.Append(type.ToString() + " : " + message);
                Console.WriteLine(builder.ToString());
                return true;
            }
        }

        public bool UnhandledException(UnhandledExceptionEventArgs args)
        {
            lock (Lock)
            {
                this.Init();
                this.Fatal("UnhandledException", (args.ExceptionObject as Exception).GetType().FullName, (args.ExceptionObject as Exception).Message);
                builder.Append(DateTime.Now.ToString("G") + " UnhandledException --> [ " + (args.ExceptionObject as Exception).GetType().FullName + " ] StackTrace :");
                Console.WriteLine(builder.ToString());
                Console.WriteLine((args.ExceptionObject as Exception).StackTrace);
                this.Warn("UnhandledException", "Application", "exit in 5 sec.");
                Thread.Sleep(5000);
                Environment.Exit(-1);
                return true;
            }
        }

        private void Init()
        {
            builder = new StringBuilder();
        }
    }
}
