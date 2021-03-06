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

        #region 私有实例

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
        /// 请求响应模型
        /// </summary>
        private static RequestResponse response;

        #endregion

        #region GET请求方法

        /// <summary>
        /// 发起Get请求
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <param name="parameters">参数列表</param>
        /// <param name="headers">请求头列表</param>
        /// <param name="format">响应格式化</param>
        /// <returns>响应内容</returns>
        public static RequestResponse GET(string Url, List<Parameters> parameters = null, List<Headers> headers = null, DataFormat format = DataFormat.Json)
        {
            try
            {
                restClient = new();
                restRequest = new(Url, Method.GET, format);
                if (parameters is not null)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        restRequest.AddParameter(parameters[i].Param, parameters[i].Value, ParameterType.GetOrPost);
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
                response = new()
                {
                    Code = restResponse.StatusCode,
                    ErrorMessage = restResponse.ErrorMessage,
                    Content = restResponse.Content
                };
                if (!restResponse.Headers.Count.Equals(0))
                {
                    for (int i = 0; i < restResponse.Headers.Count; i++)
                    {
                        response.Headers.Add(new Headers(restResponse.Headers[i].Name, restResponse.Headers[i].Value));
                    }
                }
                return response;
            }catch(Exception)
            {
                throw;
            }
        }

        #endregion

        #region POST请求方法

        /// <summary>
        /// 发起Post请求
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <param name="parameters">参数列表</param>
        /// <param name="headers">请求头列表</param>
        /// <param name="files">文件列表</param>
        /// <param name="format">响应格式化</param>
        /// <returns>响应内容</returns>
        public static RequestResponse POST(string Url, List<Parameters> parameters = null, List<Headers> headers = null, List<Files> files = null, DataFormat format = DataFormat.Json)
        {
            try
            {
                restClient = new();
                restRequest = new(Url, Method.POST, format);
                if (parameters is not null)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        restRequest.AddParameter(parameters[i].Param, parameters[i].Value, ParameterType.RequestBody);
                    }
                }
                if (headers is not null)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        restRequest.AddHeader(headers[i].Header, headers[i].Value.ToString());
                    }
                }
                if (files is not null)
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (files[i].Type.Equals(UploadType.byPath))
                            restRequest.AddFile(files[i].Name, files[i].Path);
                        else if (files[i].Type.Equals(UploadType.byBytes))
                            restRequest.AddFileBytes(files[i].Name, files[i].Bytes, files[i].FileName);
                    }
                }
                restResponse = restClient.Post(restRequest);
                response = new()
                {
                    Code = restResponse.StatusCode,
                    ErrorMessage = restResponse.ErrorMessage,
                    Content = restResponse.Content
                };
                if (!restResponse.Headers.Count.Equals(0))
                {
                    for (int i = 0; i < restResponse.Headers.Count; i++)
                    {
                        response.Headers.Add(new Headers(restResponse.Headers[i].Name, restResponse.Headers[i].Value));
                    }
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region PUT请求方法

        /// <summary>
        /// 发起Put请求
        /// </summary>
        /// <param name="Url">请求地址</param>
        /// <param name="parameters">参数列表</param>
        /// <param name="headers">请求头列表</param>
        /// <param name="files">文件列表</param>
        /// <param name="format">响应格式化</param>
        /// <returns>响应内容</returns>
        public static RequestResponse PUT(string Url, List<Parameters> parameters = null, List<Headers> headers = null, List<Files> files = null, DataFormat format = DataFormat.Json)
        {
            try
            {
                restClient = new();
                restRequest = new(Url, Method.PUT, format);
                if (parameters is not null)
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        restRequest.AddParameter(parameters[i].Param, parameters[i].Value, ParameterType.GetOrPost);
                    }
                }
                if (headers is not null)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        restRequest.AddHeader(headers[i].Header, headers[i].Value.ToString());
                    }
                }
                if (files is not null)
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        if (files[i].Type.Equals(UploadType.byPath))
                            restRequest.AddFile(files[i].Name, files[i].Path);
                        else if (files[i].Type.Equals(UploadType.byBytes))
                            restRequest.AddFileBytes(files[i].Name, files[i].Bytes, files[i].FileName);
                    }
                }
                restResponse = restClient.Put(restRequest);
                response = new()
                {
                    Code = restResponse.StatusCode,
                    ErrorMessage = restResponse.ErrorMessage,
                    Content = restResponse.Content
                };
                if (!restResponse.Headers.Count.Equals(0))
                {
                    for (int i = 0; i < restResponse.Headers.Count; i++)
                    {
                        response.Headers.Add(new Headers(restResponse.Headers[i].Name, restResponse.Headers[i].Value));
                    }
                }
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region DELETE请求方法

        

        #endregion
    }
}
