namespace Library.Shared.Models
{
    public class Author : IAuthor
    {
        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
