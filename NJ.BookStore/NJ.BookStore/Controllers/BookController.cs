using Microsoft.AspNetCore.Mvc;
using NJ.BookStore.Models;
using NJ.BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NJ.BookStore.Controllers
{
    public class BookController : Controller
    {
       //create a book repository constructor

        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View();
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
