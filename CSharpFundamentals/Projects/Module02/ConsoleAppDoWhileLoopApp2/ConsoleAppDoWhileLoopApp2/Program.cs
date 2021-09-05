using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// CalculateInterestTable -- Calculate the interest paid on a given amount over a period of years
//Ask the user to enetr in an amount if it is negative tell the user it is not valid and to enter in a new amount or exit program.
//If the amount is not negative >0 ask the user to enter an interest rate (this must not exceed the max rate of 50), if gretaer than 50 tell the suer it is not valid to
//enter a new rate or exit program
//Ask the user the number of years to claculate the interets for this must be >0 if not tell the user it is not valid and to enter in a new amount or exit program.
//Write to console, ammount, interest, duration and loop through and print out the caluclated interest for each year not ethe amount in each year will increase by adding the accrued interest

//For example the console output will look like

//Enter principal: 1234
//Enter interest: 12.5
//Enter number of years: 10
//Amount = 1234
//Interest = 12.5 %
//Duration = 10 years
//1 - 1388.25
//2 - 1561.78
//3 - 1757.00
//4 - 1976.62
//5 - 2223.70
//6 - 2501.66
//7 - 2814.37
//8 - 3166.17
//9 - 3561.94
//10 - 4007.18
//Press Enter to terminate . . 

namespace ConsoleAppDoWhileLoopApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = 2;
            decimal b = 5;
            decimal c = a * b;


                //Enter in Deposit
                Console.Write("Enter in the amount you wish to deposit:");
                string amountText = "";
                int maxRate = 50;
                amountText = Console.ReadLine();
                bool isValidAmount = decimal.TryParse(amountText, out decimal amount);


                if (isValidAmount == false)
                {

                    Console.Write("You have entered an invalid number. Please try again:");
                    Console.ReadLine();
                    return;

                }
                else if (amount <= 0)
                {
                    Console.Write("You have entered an number less than or equal to 0. Please try again:");
                    Console.ReadLine();
                    return;
                }



                // Enter in interest rate
                Console.Write("Enter in the interest rate:");
                string interestText = Console.ReadLine();
                bool interestToInt = decimal.TryParse(interestText, out decimal interest);

                if (interestToInt == false)
                {
                    Console.Write("You have entered an invalid number. Please try again:");
                    Console.ReadLine();
                    return;
                }
                else if (interest <= 0)
                {
                    Console.Write("You have entered an number less than or equal to 0 Please try again:");
                    Console.ReadLine();
                    return;
                }
               else if (interest > maxRate)
               {
                     Console.Write($"You have entered an number geater than the maximum rate of {maxRate}. Please try again:");
                     Console.ReadLine();
                     return;
               }




            // Enter in duration

            Console.Write("Enter in the number of years required:");
            string durationText = Console.ReadLine();
            bool durationToInt = decimal.TryParse(durationText, out decimal duration);

            if (durationToInt == false)
            {
                Console.Write("You have entered an invalid number. Please try again:");
                Console.ReadLine();
                return;
            }
            else if (duration <= 0)
            {
                Console.Write("You have entered an number less than or equal to 0. Please try again:");
                Console.ReadLine();
                return;
            }


            Console.WriteLine($"Amount:{amount}");
            Console.WriteLine($"Interest Rate:{interest}%");
            Console.WriteLine($"Years:{duration}");
            Console.WriteLine("The total amount plus interest accrued for each year is:");

            ////Calculate Interest on deposit

            int currentYear = 0;
            while (currentYear != duration)
            {
                currentYear++;
                decimal calculatedInterest = interest * (amount / 100);
                decimal calculatedFullAmount = (amount + calculatedInterest);
                amount = decimal.Round(calculatedFullAmount, 2);
                Console.WriteLine($"Year{currentYear}:£{amount}");
                amount = calculatedFullAmount;
                

            }

            Console.Write("End of program press enter to terminate..");
            Console.ReadLine();
        }
    }
}
