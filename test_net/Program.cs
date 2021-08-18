using System;
using System.Collections.Generic;

using CherryAya.CSharp.ToolBox.Logger;
using CherryAya.CSharp.ToolBox.Http;
using CherryAya.CSharp.ToolBox.Http.Entities;

using Newtonsoft.Json;

Logger.setLoggerLevel(LoggerLevel.Debug);
Logger.Info("Program", "LoggerLevel", Logger.getLoggerLevel());
Logger.Debug("Program", "Test", "Debug"); 
Logger.Info("Program", "Test", "Info");
Logger.Warn("Program", "Test", "Warn");
Logger.Exception("Program", "Test", "Exception");
Logger.Fatal("Program", "Test", "Fatal");

RequestResponse GetResponse = HttpRequestClient.GET("https://v1.jinrishici.com/all");
Logger.Info("HttpRequestClient", "HttpStatusCode", GetResponse.Code);
Logger.Warn("HttpRequestClient", "ErrorMessage", GetResponse.ErrorMessage);
for (int i = 0; i < GetResponse.Headers.Count; i++)
{
    Logger.Info("HttpRequestClient", "Header", GetResponse.Headers[i].ToString());
}
dynamic json = JsonConvert.DeserializeObject<dynamic>(GetResponse.Content);
Logger.Info("HttpRequestClient", "Content", json.content);

List<Parameters> parameters = new List<Parameters>();
parameters.Add(new Parameters("tag", "白丝"));
parameters.Add(new Parameters("r18", 1));
RequestResponse PostResponse = HttpRequestClient.POST("https://api.lolicon.app/setu/v2", parameters);
dynamic lolicon = JsonConvert.DeserializeObject<dynamic>(PostResponse.Content);
Logger.Info("HttpRequestClient", "POST", lolicon.data[0].urls.original);
