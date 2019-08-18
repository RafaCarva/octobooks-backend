using Dapper;
using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        new Book Insert(Book obj);
        new bool Remove(Book obj);
        new List<Book> GetAll();
        new Book GetById(int id);
        new List<Book> Query(string query, DynamicParameters parameters);
    }
}
