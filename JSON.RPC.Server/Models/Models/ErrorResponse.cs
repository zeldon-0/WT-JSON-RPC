using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models.Models
{
    public class ErrorResponse : IResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }
        public Error Error { get; set; }
        public int? Id { get; set; }
    }

    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

}
