using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Octobooks.Domain.Models;
using Octobooks.Repository.Base;
using Octobooks.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(IConfiguration config, ILogger<Repository<Book>> logger) : base(config, logger)
        {

        }
    }
}
