using System;
using MongoDB.Bson;

namespace Server.Models
{
    // TODO: fix this - change to objectId
    public class User
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}