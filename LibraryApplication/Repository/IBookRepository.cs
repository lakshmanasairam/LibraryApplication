using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();

        Book GetBookById(int id);

        void CreateBook(Book book);

        void UpdateBook(int? id, Book book);

        void DeleteBook(int? id);

    }
}
