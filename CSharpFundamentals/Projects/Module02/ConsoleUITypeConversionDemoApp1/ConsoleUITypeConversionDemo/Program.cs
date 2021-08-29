using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Capture a users age from the Console and then identify how old they were in the year 2000. 
If they were not born yet tell them that instead
 */

namespace ConsoleUITypeConversionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

    
                Console.Write("What year were you born in:");
                string usersAgeTextIn = Console.ReadLine();

                bool isValidAge = int.TryParse(usersAgeTextIn, out int age);

                if ((isValidAge == true) & (age < 2000))

                {
                    age = 2000 - age;
                    Console.WriteLine($"You are {age} year(s) old");
                }
                else
                {
                    Console.WriteLine("You were not born before the year 2000");
                }
                Console.ReadLine();
            
        }
    }
    
}
