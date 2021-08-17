using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using CherryAya.CSharp.ToolBox.Http.Entities;

namespace CherryAya.CSharp.ToolBox.Http
{
    public class HttpRequestClient
    {
        public static GetRequestResponse GET(string Url, List<Parameters> parameters = null, List<Headers> headers = null, DataFormat format = DataFormat.Json)
        {
            try
            {
                RestClient restClient = new RestClient();
                RestRequest restRequest = new RestRequest(Url, format);
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
                IRestResponse restResponse = restClient.Get(restRequest);
                GetRequestResponse response = new GetRequestResponse();
                response.Code = restResponse.StatusCode;
                response.ErrorMessage = restResponse.ErrorMessage;
                response.Context = restResponse.Content;
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
    }
}
