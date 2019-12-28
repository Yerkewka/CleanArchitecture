using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccountOwnerServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repositoryWrapper;

        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var owners = _repositoryWrapper.Owner.FindAll();
            var domesticAccounts = _repositoryWrapper.Account.FindByCondition(x => x.AccountType == "Domestic");

            _logger.LogInfo("Get request to account owners");

            return Ok(new
            {
                owners,
                domesticAccounts
            });
        }
    }
}
