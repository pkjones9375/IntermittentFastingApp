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
        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("SELECT * FROM users;");
        }

        public User GetUser(int userID)
        {
            return (User) _conn.QuerySingle<User>("SELECT * FROM users WHERE userid = @id",
                new { id = userID });
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

        //Inserts new weight info for user
        public void WeighIn(WeightInfo newWeight)
        {
            _conn.Execute("INSERT INTO weights(WeighIn, WeighInDate, UserID) VALUES(@WeighIn, @Date @UserID)",
                new { WeighIn = newWeight.WeighIn, date = newWeight.WeighIn, UserID = newWeight.UserID });
            //***Need to connect this in UserController, UpdateUser***
        }

        public void UpdateUser(User user)
        {
            //***We need to figure out what parameters we want to update and how. How to update weight?
            //_conn.Execute("UPDATE users SET ")
        }

        //DELETE user. Connects to UserController
        public void DeleteUser(User userToDelete)
        {
            _conn.Execute("DELETE FROM users WHERE UserID = @id;",
                new { id = userToDelete.UserID }); //B: I'm guessing on this variable name
        }
    }
}
