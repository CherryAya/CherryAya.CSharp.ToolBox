using System;
using CherryAya.CSharp.ToolBox.Logger;
using CherryAya.CSharp.ToolBox.Http;
using CherryAya.CSharp.ToolBox.Http.Entities;
using System.Collections.Generic;

Logger.setLoggerLevel(LoggerLevel.Debug);
Console.WriteLine(Logger.getLoggerLevel().ToString());

Logger.Debug("Program", "Test", "Debug"); 
Logger.Info("Program", "Test", "Info");
Logger.Warn("Program", "Test", "Warn");
Logger.Exception("Program", "Test", "Exception");
Logger.Fatal("Program", "Test", "Fatal");

List<Parameters> parameters = new List<Parameters>();
parameters.Add(new Parameters("num", 10));
parameters.Add(new Parameters("r18", 1));

HttpRequestClient.GET("https://api.lolicon.app/setu/v2/", parameters); 
