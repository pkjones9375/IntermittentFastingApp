using Dapper;
using IntermittentFasting.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace IntermittentFasting
{
    //Here's the layout for our IF user info. Console will get/set BMI info
    //UserID will act as Primary Key in SQL
    public class UserRepository : IUserRepository //B: Why does this have squiggles?
    {
        private readonly IDbConnection _conn; //B: Is this connected to the connection?
        
        public UserRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("SELECT * FROM users;");
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

        public void WeighIn(WeightInfo newWeight)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            //***We need to figure out what parameters we want to update and how. How to update weight?
            //_conn.Execute("UPDATE users SET ")
        }

        //Implementing the DeleteUser() to remove users from database.
        //Should connect to Models.User
        public void DeleteUser(User user)
        {
            _conn.Execute("DELETE FROM users WHERE UserID = @id;",
                new { id = user.UserID });

            _conn.Execute("DELETE FROM weights WHERE UserID = @id;",
                new { id = user.UserID });
        }
    }
}
