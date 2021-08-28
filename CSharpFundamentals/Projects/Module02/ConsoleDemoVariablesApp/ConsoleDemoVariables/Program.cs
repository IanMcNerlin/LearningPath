using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********************************************
            //Create a console application that has variables to hold a persons name, age, if they are alive and theire phone number
            //***********************************************

            
            string firstName = "";
            string lastName = "";
            string fullName = "";
            int ageOfPerson = 0;
            bool isPersonAlive = false;
            string phoneNumberOfPerson = "";

            firstName = "Ian";
            lastName = "Smith";
            fullName = $"{firstName} {lastName}";
            ageOfPerson = 48;
            isPersonAlive = true;
            phoneNumberOfPerson = "01245-89532";

            Console.WriteLine($"Name:{fullName}");
            Console.WriteLine($"Age:{ageOfPerson}");
            Console.WriteLine($"Is Alive:{isPersonAlive}");
            Console.WriteLine($"Phone Number:{phoneNumberOfPerson}");

            Console.ReadLine();
        }
    }
}
