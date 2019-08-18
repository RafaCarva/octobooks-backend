using Octobooks.Business.Interfaces;
using Octobooks.Domain.Models;
using Octobooks.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Business
{
    public class LoanBusiness : ILoanBusiness
    {
        private readonly ILoanRepository _loanRepository;

        public LoanBusiness(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void Delete(Loan loan)
        {
            _loanRepository.Remove(loan);
        }

        public List<Loan> GetAll()
        {
            return _loanRepository.GetAll();
        }

        public Loan GetById(int id)
        {
            return _loanRepository.GetById(id);
        }

        public Loan Insert(Loan loan)
        {
            return _loanRepository.Insert(loan);
        }
    }
}
