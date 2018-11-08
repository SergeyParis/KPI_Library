namespace Library.Core.Shared
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public Book() { }
        public Book(string name, string iSBN, Author author)
        {
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentException("Name can't be empty") : name;
            ISBN = string.IsNullOrEmpty(iSBN) ? throw new ArgumentException("iSBN can't be empty") : iSBN;
            Author = author ?? throw new NullReferenceException();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        public bool IsGivenUse { get; set; } = false;

        public int AuthorId { get; set; }

        public int? ClientId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Client Client { get; set; }

    }
}
