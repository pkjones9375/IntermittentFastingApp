using IntermittentFasting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace IntermittentFasting
{
    public interface IUserRepository
    {
        //our stubbed-out methods that PK wrote
        //user table 
        public IEnumerable<User> GetAllUsers();
        public void NewUser(User newUser); //CREATE
        public User GetUser(int userID);   //READ
        public void UpdateUser(User user); //UPDATE
        public void DeleteUser(User user); //DELETE
        
        //weight table
        public IEnumerable<WeightInfo> GetWeightInfo();
        public void WeighIn(WeightInfo newWeight);
    }
}
