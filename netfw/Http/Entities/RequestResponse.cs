using System.Collections.Generic;
using System.Net;

namespace CherryAya.CSharp.ToolBox.netfw.Http.Entities
{
    /// <summary>
    /// 请求响应模型
    /// </summary>
    public class RequestResponse
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
        public string Content { get; set; }
        /// <summary>
        /// 响应头列表
        /// </summary>
        public List<Headers> Headers { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public RequestResponse()
        {
            Headers = new List<Headers>();
        }
    }
}
