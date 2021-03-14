using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models.Models
{
    public class Request
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }
        public string Method { get; set; }
        public IReadOnlyCollection<object> Params { get; set; }
        public int Id { get; set; }
    }
}
