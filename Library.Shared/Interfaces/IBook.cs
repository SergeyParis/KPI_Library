namespace Library.Shared
{
    public interface IBook
    {
        int Id { get; set; }
        int ISBN { get; set; }
        bool IsGivenUse { get; set; }
        IAuthor Author { get; set; }
        IClient Client { get; set; }
    }
}
