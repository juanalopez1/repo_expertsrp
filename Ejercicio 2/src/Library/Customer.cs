using System;
using System.Text;

namespace Library
{
    public class Customer
    {
        public string name;
        public string id;
        public string phoneNumber;
        public string age;

        public Customer(string name, string id, string phoneNumber, string age)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.age = age;
        } 
        
    }
}
