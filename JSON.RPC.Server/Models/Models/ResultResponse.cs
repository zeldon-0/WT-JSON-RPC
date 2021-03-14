using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models.Models
{
    public class ResultResponse : IResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }
        public object Result { get; set; }
        public int? Id { get; set; }
    }
}
