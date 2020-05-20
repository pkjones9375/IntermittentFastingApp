using IntermittentFasting.Models;
using System;
using System.Collections.Generic;

namespace IntermittentFasting
{
    //Here's the layout for our IF user info. Console will get/set BMI info
    //UserID will act as Primary Key in SQL
    public class UserRepository : IUserRepository   
    {
        public void DeleteUser(User userToDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
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
    }
}
