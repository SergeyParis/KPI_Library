using Library.Shared;

namespace Library.Core.EntityFramework
{
    public class AuthorWrap : IAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AuthorWrap() { }
        public AuthorWrap(IAuthor author)
        {
            Id = author.Id;
            Name = author.Name;
        }
    }
}
