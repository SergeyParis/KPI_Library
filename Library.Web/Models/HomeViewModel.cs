using Library.Core.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Web
{
    public sealed class HomeViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Select a correct license")]
        public EntityType EntityType { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}