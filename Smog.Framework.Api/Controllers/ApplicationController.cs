using Microsoft.AspNetCore.Mvc;

namespace Smog.Framework.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {

        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(ILogger<ApplicationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Search")]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 5);
        }

        [HttpPost]
        public IEnumerable<int> Post()
        {
            return Enumerable.Range(1, 5);
        }

        [HttpPut]
        public IEnumerable<int> Put()
        {
            return Enumerable.Range(1, 5);
        }

        [HttpDelete]
        public IEnumerable<int> Delete()
        {
            return Enumerable.Range(1, 5);
        }
    }
}