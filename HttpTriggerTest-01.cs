using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace VSoft.Functions.Test
{
    public class HttpTriggerTest_01
    {
        private readonly ILogger<HttpTriggerTest_01> _logger;

        public HttpTriggerTest_01(ILogger<HttpTriggerTest_01> logger)
        {
            _logger = logger;
        }

        [Function("HttpTriggerTest_01")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
