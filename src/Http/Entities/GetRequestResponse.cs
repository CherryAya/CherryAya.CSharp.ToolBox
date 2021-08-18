using System.Collections.Generic;
using System.Net;

namespace CherryAya.CSharp.ToolBox.Http.Entities
{
    /// <summary>
    /// GET请求响应模型
    /// </summary>
    public class GetRequestResponse
    {
        /// <summary>
        /// HTTP状态
        /// </summary>
        public HttpStatusCode Code { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        ///  响应内容
        /// </summary>
        public string Context { get; set; }
        /// <summary>
        /// 响应头列表
        /// </summary>
        public List<Headers> Headers { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public GetRequestResponse()
        {
            Headers = new List<Headers>();
        }
    }
}
