namespace Library.Core.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Library.Core.Shared;

    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryModel")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Book>()
                .Property(e => e.ISBN)
                .IsFixedLength();

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
