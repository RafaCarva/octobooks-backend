using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface ILoanRepository : IRepository<Loan>
    {
        new Loan Insert(Loan obj);
        new bool Remove(Loan obj);
        new List<Loan> GetAll();
        new Loan GetById(int id);
        new List<Loan> Query(string query, DynamicParameters parameters);
    }
}
