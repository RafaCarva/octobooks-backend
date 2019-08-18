using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface ILoanRepository : IRepository<Loan>
    {
        Loan Insert(Loan obj);
        bool Remove(Loan obj);
        List<Loan> GetAll();
        Loan GetById(int id);
        List<Loan> Query(string query, DynamicParameters parameters);
    }
}
