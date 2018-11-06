namespace Library.Shared
{
    public interface IBook
    {
        int Id { get; set; }
        string ISBN { get; set; }
        bool IsGivenUse { get; set; }
        IAuthor Author { get; set; }
        IClient Client { get; set; }

        void GiveInUse(IClient client);
        void TakeFromUse();
    }
}
