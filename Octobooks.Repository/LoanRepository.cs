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
    public class LoanRepository : Repository<Loan>, ILoanRepository
    {
        public LoanRepository(IConfiguration config, ILogger<Repository<Loan>> logger) : base(config, logger)
        {

        }

    }
}
