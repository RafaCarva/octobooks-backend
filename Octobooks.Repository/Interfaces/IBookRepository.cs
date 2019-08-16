using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Book Insert(Book obj);
        bool Remove(Book obj);
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> Query(string query, DynamicParameters parameters);
    }
}
