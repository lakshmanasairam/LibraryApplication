using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int? id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1, BookName="Wings of fire", Author="APJ Kalam", ISBN="IS1234", PublishedDate=Convert.ToDateTime("10/10/2012")},
                new Book{Id=2, BookName="Harry Potter", Author="JK Rowling", ISBN="IS1235", PublishedDate=Convert.ToDateTime("09/12/2010")},
                new Book{Id=3, BookName="The Diary Of Young Girl", Author="Anne Frank", ISBN="IS1236", PublishedDate=Convert.ToDateTime("21/04/2012")}

            };
        }

        public void UpdateBook(int? id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
