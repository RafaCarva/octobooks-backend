using Octobooks.Business.Interfaces;
using Octobooks.Domain.Models;
using Octobooks.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Business
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookRepository _bookRepository;

        public BookBusiness(IBookRepository bookRepository)
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
