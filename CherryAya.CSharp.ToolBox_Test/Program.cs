using System;
using CherryAya.CSharp.ToolBox.Logger;

Logger.setLoggerLevel(LoggerLevel.Debug);
Console.WriteLine(Logger.getLoggerLevel().ToString());

Logger.Debug("Program", "Test", "Debug"); 
Logger.Info("Program", "Test", "Info");
Logger.Warn("Program", "Test", "Warn");
Logger.Exception("Program", "Test", "Exception");
Logger.Fatal("Program", "Test", "Fatal");