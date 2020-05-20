﻿using Dapper;
using IntermittentFasting.Models;
using System;
using System.Collections.Generic;
using System.Data;


namespace IntermittentFasting
{
    //Here's the layout for our IF user info. Console will get/set BMI info
    //UserID will act as Primary Key in SQL
    public class UserRepository : IUserRepository   
    {
        private readonly IDbConnection _conn;

        public UserRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void DeleteUser(User userToDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("SELECT * From users;");
        }

        public User GetUser(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeightInfo> GetWeightInfo()
        {
            throw new NotImplementedException();
        }

        public void NewUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void WeighIn(WeightInfo newWeight)
        {
            throw new NotImplementedException();
        }
    }
}