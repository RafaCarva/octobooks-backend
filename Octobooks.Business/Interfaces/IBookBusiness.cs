using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Business.Interfaces
{
    public interface IBookBusiness
    {
        void Delete(Book book);
        Book Insert(Book book);
        List<Book> GetAll();
        Book GetById(int id);
    }
}
