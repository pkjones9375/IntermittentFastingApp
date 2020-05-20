using System;
namespace IntermittentFasting
{
    //Here's the layout for our IF user info. Console will get/set BMI info
    //UserID will act as Primary Key in SQL
    public class UserRepository
        //*****Changed name of class to UserRepository, as it doesn't call the methods
        //written by the IFastingRepository
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int HeightInches { get; set; }
        public int Weight { get; set; }
        public decimal StartBMI { get; set; }
        public decimal LastBMI { get; set; }
        public int TimeToFast { get; set; }
        public DateTime Date { get; set; }
        
    }
}
