namespace Library.Shared
{
    public interface IClient
    {
        int Id { get; set; }
        string Name { get; set; }
        int CountBooksNow { get; set; }
    }
}
