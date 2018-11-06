using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Library.Core.EntityFramework
{
    class LibraryContext : DbContext
    {
        public LibraryContext() : base("") { }

        public DbSet<BookWrap> Books { get; set; }
        public DbSet<AuthorWrap> Authors { get; set; }
        public DbSet<ClientWrap> Clients { get; set; }
    }
}
