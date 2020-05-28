using Dapper;
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
            _conn.Execute("INSERT INTO users (FIRSTNAME, LASTNAME, HEIGHTININCHES, STARTWEIGHT, TIMETOFAST) " +
                "VALUES (@FirstName, @LastName, @HeightInInches, @StartWeight, @TimeToFast);",
             new { FIRSTNAME = newUser.FirstName, LASTNAME = newUser.LastName, HEIGHTININCHES = newUser.HeightInInches, 
                 STARTWEIGHT = newUser.StartWeight, TIMETOFAST = newUser.TimeToFast }) ;
            
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
    }
}
