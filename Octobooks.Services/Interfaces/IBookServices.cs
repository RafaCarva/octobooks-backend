using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services.Interfaces
{
    public interface IBookServices
    {
        void Delete(Book book);
        Book Insert(Book book);
        List<Book> GetAll();
        Book GetById(int id);
    }
}
