using IntermittentFasting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// BRETT'S NOTE: I think that this segment might be superfluous. Delete later?
namespace IntermittentFasting
{
    interface IUserRepository
    {
        //our stubbed-out methods that PK wrote
        //user table 
        public IEnumerable<User> GetAllUsers();
        public User GetUser(int userID);
        public void NewUser(User newUser);
        public void DeleteUser(User userToDelete);
        
        //weight table

        public IEnumerable<WeightInfo> GetWeightInfo();
        public void WeighIn(WeightInfo newWeight);
    }
}
