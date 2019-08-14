using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Octobooks.Domain.Models;
using Octobooks.Services.Interfaces;

namespace Octobooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientServices _clientService;

        public ClientController(IClientServices clientServices)
        {
            _clientService = clientServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            try
            {
               // _logger.LogInformation("Received get request");

                return Ok(_clientService.GetAll());
            }
            catch (Exception exception)
            {
               // _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}