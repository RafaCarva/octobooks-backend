using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octobooks.Domain.Models;
using Octobooks.Services.Interfaces;

namespace Octobooks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class BookController : Controller
    {
        private readonly IBookServices _bookServices;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookServices bookServices, ILogger<BookController> logger)
        {
            _bookServices = bookServices;
            _logger = logger;
        }

        // GET: Book
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                _logger.LogInformation("Received get request");
                return Ok(_bookServices.GetAll());
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        // GET: Book/Details/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var client = _bookServices.GetById(id); 
            return Ok(client);
        }

        // POST api/book
        [HttpPost]
        public ActionResult<string> Post([FromBody] Book book)
        {
            try
            {
                _logger.LogInformation("Received post request");
                var clientEntity = _bookServices.Insert(book);
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