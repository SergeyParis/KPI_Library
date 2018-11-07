using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Library.Core.DataBase;
using Library.Core.Shared;

namespace Library.Core
{
    public static class BookManager
    {
        private static LibraryContext _context;

        static BookManager()
        {
            _context = new LibraryContext();
        }
        
        public static IEnumerable<Book> GetAllBooks() => _context.Books.Include(c => c.AuthorId).Include(c => c.ClientId).ToArray();

        public static void AddBook(Book book)
        {
            _context.Books.Add(book);

            _context.SaveChanges();
        }

        public static void GiveBookInUse(int bookId, int clientId)
        {


            _context.SaveChanges();
        }
    }
}
