using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octobooks.Services.Interfaces;
using Octobooks.Domain.Models;
using Microsoft.AspNetCore.Cors;

namespace Octobooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class LoanController : Controller
    {
        private readonly ILoanServices _loanService;
        private readonly ILogger<LoanController> _logger;

        public LoanController(ILoanServices loanServices, ILogger<LoanController> logger)
        {
            _loanService = loanServices;
            _logger = logger;
        }

        // GET: api/Loan
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                return Ok(_loanService.GetAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        // GET: api/Loan/5
        [HttpGet("{id}")]
        public ActionResult<Client> GetById(int id)
        {
            var loan = _loanService.GetById(id);  
            return Ok(loan);
        }

        // POST: api/Loan
        [HttpPost]
        public ActionResult<string> Post([FromBody] Loan loan)
        {
            try
            {
                _logger.LogInformation("Received post request");
                var clientEntity = _loanService.Insert(loan);

                return Ok("success");
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
        /*
        // PUT: api/Loan/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
