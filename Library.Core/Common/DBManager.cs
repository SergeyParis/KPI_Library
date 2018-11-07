using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Library.Core.DataBase;
using Library.Core.Shared;

namespace Library.Core
{
    public static class DBManager
    {
        private static LibraryContext _context;

        static DBManager()
        {
            _context = new LibraryContext();
        }
        
        public static IEnumerable<Book> GetAllBooks() => _context.Books.Include(c => c.Author).Include(c => c.Client).ToArray();
        public static Author GetAuthorByName(string name) => _context.Authors.Where(o => o.Name == name).First();
        public static Client GetClientByName(string name) => _context.Clients.Where(o => o.Name == name).First();

        public static void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public static void AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public static void AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public static void GiveBookInUse(int bookId, int clientId)
        {


            _context.SaveChanges();
        }
    }
}
