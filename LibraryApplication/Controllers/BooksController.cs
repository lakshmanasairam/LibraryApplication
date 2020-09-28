using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApplication.Models;
using LibraryApplication.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepos = null;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _bookRepos.CreateBook(book);

            return RedirectToAction("Index", "Books");
        }

        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult UpdateBook(int id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.UpdateBook(id, book);
            return RedirectToAction("Index", "Books");
        }

        [HttpPost]
        public IActionResult DeleteBook(int? id)
        {
            _bookRepos.DeleteBook(id);
            return RedirectToAction("Index", "Books");
        }
    }
}
