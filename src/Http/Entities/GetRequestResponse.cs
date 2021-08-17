using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CherryAya.CSharp.ToolBox.Http.Entities
{
    public class GetRequestResponse
    {
        public HttpStatusCode Code { get; set; }
        public string ErrorMessage { get; set; }
        public string Context { get; set; }
        public List<Headers> Headers { get; set; }
    }
}
