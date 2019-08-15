using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Octobooks.Domain.Models;
using Octobooks.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace Octobooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientServices _clientService;
        private readonly ILogger<ClientController> _logger;

        public ClientController(IClientServices clientServices, ILogger<ClientController> logger)
        {
            _clientService = clientServices;
            _logger = logger;
        }

        // GET api/client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                return Ok(_clientService.GetAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        // GET api/client/1
        [HttpGet("{id}")]
        public ActionResult<Client> GetById(int id)
        {
            var client = _clientService.GetById(id);  //_mapper.Map<ClientViewModel>(_clientservices.GetById(id));
            return Ok(client);
        }

        // POST api/client
        [HttpPost]
        public ActionResult<string> Post([FromBody] Client client)
        {
            try
            {
                //if (!ModelState.IsValid) return BadRequest(client);
                _logger.LogInformation("Received post request");
                var clientEntity = _clientService.Insert(client);
                //if (clientEntity.ValidationResult.Errors.Any()) return AddValidationErrors(clientEntity.ValidationResult.Errors);

                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

    }
}