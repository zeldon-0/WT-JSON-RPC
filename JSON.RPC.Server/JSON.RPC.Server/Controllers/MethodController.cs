using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MethodLayer;

namespace JSON.RPC.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MethodController : ControllerBase
    {
        private readonly IMethodOrchestrator _methodOrchestrator;

        public MethodController(IMethodOrchestrator methodOrchestrator)
        {
            _methodOrchestrator = methodOrchestrator;
        }

        [HttpPost]
        public IActionResult InvokeMethod(object request)
        {
            var response = _methodOrchestrator.Invoke(request);
            return Ok(response);
        }
    }
}
