using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using CherryAya.CSharp.ToolBox.Http.Entities;

namespace CherryAya.CSharp.ToolBox.Http
{
    public static class HttpRequestClient
    {
        /// <summary>
        /// RestClient实例
        /// </summary>
        private static RestClient restClient;
        /// <summary>
        /// RestRequest实例
        /// </summary>
        private static RestRequest restRequest;
        /// <summary>
        /// RestResponse实例
        /// </summary>
        private static IRestResponse restResponse;

        /// <summary>
        /// Get请求响应模型
        /// </summary>
        private static GetRequestResponse GetResponse;

        /// <summary>
        /// 发起Get请求
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <param name="parameters">参数列表</param>
        /// <param name="headers">请求头列表</param>
        /// <param name="format">数据格式化</param>
        /// <returns>响应内容</returns>
        public static GetRequestResponse GET(string Url, List<Parameters> parameters = null, List<Headers> headers = null, DataFormat format = DataFormat.Json)
        {
            try
            {
                restClient = new();
                restRequest = new(Url, format);
                if (parameters is not null)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        restRequest.AddParameter(parameters[i].Param, parameters[i].Value);
                    }
                }
                if (headers is not null)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        restRequest.AddHeader(headers[i].Header, headers[i].Value.ToString());
                    }
                }
                restResponse = restClient.Get(restRequest);
                GetResponse = new GetRequestResponse
                {
                    Code = restResponse.StatusCode,
                    ErrorMessage = restResponse.ErrorMessage,
                    Content = restResponse.Content
                };
                if (!restResponse.Headers.Count.Equals(0))
                {
                    for (int i = 0; i < restResponse.Headers.Count; i++)
                    {
                        GetResponse.Headers.Add(new Headers(restResponse.Headers[i].Name, restResponse.Headers[i].Value));
                    }
                }
                return GetResponse;
            }catch(Exception)
            {
                throw;
            }
        }
    }
}
