using Octobooks.Business.Interfaces;
using Octobooks.Domain.Models;
using Octobooks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services
{
    public class LoanServices : ILoanServices
    {
        private readonly ILoanBusiness _loanBusiness;

        public LoanServices(ILoanBusiness loanBusiness)
        {
            _loanBusiness = loanBusiness;
        }

        public void Delete(Loan loan)
        {
            _loanBusiness.Delete(loan);
        }

        public List<Loan> GetAll()
        {
            return _loanBusiness.GetAll();
        }

        public Loan GetById(int id)
        {
            return _loanBusiness.GetById(id);
        }

        public Loan Insert(Loan loan)
        {
            return _loanBusiness.Insert(loan);
        }

    }
}
