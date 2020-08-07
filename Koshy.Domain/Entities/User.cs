using System;
using System.Collections.Generic;

namespace Koshy.Domain.Entities
{
    public class User
    {
        public Guid Code { get; set; } = Guid.NewGuid();
        public string Username { get; set; }

        private static readonly IEnumerable<User> _list = new List<User>() { new User("Lorem"), new User("Ipsum") };

        public User(string username) => Username = username;

        public static IEnumerable<User> GetList() => _list;
    }
}