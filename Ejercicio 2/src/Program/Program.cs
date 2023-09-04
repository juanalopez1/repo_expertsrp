using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer steven = new Customer("Steven Jhonson", "986782342", "5555-555-555", "34");
            Customer ralf = new Customer("Ralf Manson", "55018624", "5555-555-555","45");
            Doctor doctor1= new Doctor("Armand", "surgeon");
            Doctor doctor2= new Doctor("Megan", "Oncologist");

            string appointmentResult = ValidInfo.isValid(steven, DateTime.Now, "Wall Street", doctor1);
            if (appointmentResult == "True")
            {
                Console.WriteLine("Appoinment schedule");
            }
            else
            {Console.WriteLine(appointmentResult);}

            string appointmentResult2 = ValidInfo.isValid(ralf, DateTime.Now, "Queen Street", doctor2);
            if (appointmentResult2 == "True")
            {
                Console.WriteLine("Appoinment schedule");
            }
            else
            {Console.WriteLine(appointmentResult);}
        }
    }
}
