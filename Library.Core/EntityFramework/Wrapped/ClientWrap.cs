﻿using Library.Shared;

namespace Library.Core.EntityFramework
{
    public class ClientWrap : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountBooksNow { get; set; }

        public Client() { }
        public Client(IClient client)
        {
            Id = client.Id;
            Name = client.Name;
            CountBooksNow = client.CountBooksNow;
        }
    }
}
