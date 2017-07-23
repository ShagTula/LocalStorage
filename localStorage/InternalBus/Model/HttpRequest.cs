using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.InternalBus.Model
{
    class HttpRequest
    {
        public string url { get; set; }
        public string method { get; set; }
        public Dictionary<string, string> headers { get; set; }
        public Dictionary<string, string> getParams { get; set; }
        public Dictionary<string, string> bodyParams { get; set; }
        public string rawBody { get; set; }
    }
}
