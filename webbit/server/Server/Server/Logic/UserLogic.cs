﻿using System;
using System.Configuration;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models;
using Server.ViewModels;

namespace Server.Logic
{    
    public class UserLogic
    {
        // TODO: fix this - change to imongocollection
        protected IMongoCollection<User> Collection { get; }

        public UserLogic()
        {
            // TODO: fix this
            var client = new MongoClient(ConfigurationManager.AppSettings["MongoURL"]);
            //var server = client.();
            Collection = client.GetDatabase("webbit").GetCollection<User>("users");
        }

        public UserViewModel Login(LoginViewModel loginViewModel)
        {
            var user =  Collection.AsQueryable().SingleOrDefault(x =>
                x.Password == loginViewModel.Password &&
                x.Username == loginViewModel.UserName);
            
            if (user == null)
            {
                // TODO: fix this - throw specific exception for exception filter
                throw new NullReferenceException();
            }

            return new UserViewModel(user);
        }
    }
}