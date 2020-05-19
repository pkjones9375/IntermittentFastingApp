using IntermittentFasting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermittentFasting
{
    interface IIFastingRepository
    {
        //our stubbed-out methods that PK wrote
        //user table 
        public IEnumerable<UserInfo> GetAllUsers();
        public UserInfo GetUser(int userID);
        public void NewUser(UserInfo newUser);
        public void DeleteUser(UserInfo userToDelete);
        

        //weight table

        public IEnumerable<WeightInfo> GetWeightInfo();
        public void WeighIn(WeightInfo newWeight);
        
    }
}
