using System;
using CherryAya.CSharp.ToolBox.Logger;
using CherryAya.CSharp.ToolBox.Http;
using CherryAya.CSharp.ToolBox.Http.Entities;
using System.Collections.Generic;

Logger.setLoggerLevel(LoggerLevel.Debug);
Logger.Info("Program", "LoggerLevel", Logger.getLoggerLevel());
Logger.Debug("Program", "Test", "Debug"); 
Logger.Info("Program", "Test", "Info");
Logger.Warn("Program", "Test", "Warn");
Logger.Exception("Program", "Test", "Exception");
Logger.Fatal("Program", "Test", "Fatal");

List<Parameters> parameters = new List<Parameters>();
parameters.Add(new Parameters("num", 10));
parameters.Add(new Parameters("r18", 1));
GetRequestResponse response = HttpRequestClient.GET("https://api.lolicon.app/setu/v2/", parameters);

Console.WriteLine(response.Code);
Console.WriteLine(response.ErrorMessage);
for (int i = 0; i < response.Headers.Count; i++)
{
    Console.WriteLine(response.Headers[i].ToString());
}
Console.WriteLine(response.Context);