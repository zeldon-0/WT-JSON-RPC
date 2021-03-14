using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Models
{
    public interface IResponse
    {
        string Jsonrpc { get; set; }
        int? Id { get; set; }
    }
}
