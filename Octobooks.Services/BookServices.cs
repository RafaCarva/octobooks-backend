using Octobooks.Domain.Models;
using Octobooks.Repository.Interfaces;
using Octobooks.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _bookRepository;
        public BookServices(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Delete(Book book)
        {
            _bookRepository.Remove(book);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public Book Insert(Book book)
        {
            return _bookRepository.Insert(book);
        }
    }
}
