using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services.Interfaces
{
    public interface ILoanServices
    {
        void Delete(Loan loan);
        Loan Insert(Loan loan);
        List<Loan> GetAll();
        Loan GetById(int id);
    }
}
