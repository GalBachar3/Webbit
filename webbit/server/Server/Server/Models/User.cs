using System;

namespace Server.Models
{
    // TODO: fix this - add guid init
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}