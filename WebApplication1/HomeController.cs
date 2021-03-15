using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
            {
            _logger=logger;
            }

        [HttpGet("[action]")]
        public IActionResult Index()
        {
            _logger.LogInformation($"Index request at {DateTime.Now:hh.mm.ss}");
            var i = GetRandomInt();
            try
            {
                var result = 100 / i;
                _logger.LogInformation($"100 divide {i} the result is {result}");
            }
            catch (Exception exception) {  _logger.LogError($"Random value equals {i} and that's why error is: {exception.Message}"); }

            return Ok();
        }
        private int GetRandomInt() { return new Random().Next(0, 5); }
    }
}
