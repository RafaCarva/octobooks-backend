using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Business.Interfaces
{
    public interface ILoanBusiness
    {
        void Delete(Loan client);
        Loan Insert(Loan client);
        List<Loan> GetAll();
        Loan GetById(int id);
    }
}
