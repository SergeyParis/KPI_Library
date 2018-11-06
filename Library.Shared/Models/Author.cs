namespace Library.Shared.Models
{
    public class Author : IAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }
    }
}
