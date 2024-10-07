using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class Test_Http_trigger
    {
        private readonly ILogger<Test_Http_trigger> _logger;

        public Test_Http_trigger(ILogger<Test_Http_trigger> logger)
        {
            _logger = logger;
        }

        [Function("Test_Http_trigger")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
