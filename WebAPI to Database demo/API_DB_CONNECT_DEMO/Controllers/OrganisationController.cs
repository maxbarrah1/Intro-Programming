/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_DB_CONNECT_DEMO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganisationController : ControllerBase
    {

        private readonly ILogger<OrganisationController> _logger;

        public OrganisationController(ILogger<OrganisationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Organisation> Get()
        {
            return DatabaseHandler.GetOrganisationBriefs{};

        }
    }
}
*/