using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CherryAya.CSharp.ToolBox.netfw.Logger;
using CherryAya.CSharp.ToolBox.netfw.Http;
using CherryAya.CSharp.ToolBox.netfw.Http.Entities;
using Newtonsoft.Json;

namespace CherryAya.CSharp.ToolBox_Test.netfw
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.setLoggerLevel(LoggerLevel.Debug);
            Logger.Info("Program", "LoggerLevel", Logger.getLoggerLevel());
            Logger.Debug("Program", "Test", "Debug");
            Logger.Info("Program", "Test", "Info");
            Logger.Warn("Program", "Test", "Warn");
            Logger.Exception("Program", "Test", "Exception");
            Logger.Fatal("Program", "Test", "Fatal");

            GetRequestResponse response = HttpRequestClient.GET("https://v1.jinrishici.com/all");
            Logger.Info("HttpRequestClient", "HttpStatusCode", response.Code);
            Logger.Warn("HttpRequestClient", "ErrorMessage", response.ErrorMessage);
            for (int i = 0; i < response.Headers.Count; i++)
            {
                Logger.Info("HttpRequestClient", "Header", response.Headers[i].ToString());
            }
            dynamic json = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Logger.Info("HttpRequestClient", "Content", json.content);
            Console.ReadKey();
        }
    }
}
