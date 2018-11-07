namespace Library.Core.Shared
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        public bool IsGivenUse { get; set; }

        public int AuthorId { get; set; }

        public int? ClientId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Client Client { get; set; }
    }
}
