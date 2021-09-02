using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console UI that asks the user to enter a amount, and an interest rate return the sum of amount and inetrest that would be paid. If a negative amount or interest value is enetred return an error
 */

namespace ConsoleUIMiniProjectDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter in the amount you wish to deposit:");
            string amountText = "";
            amountText = Console.ReadLine();
            bool isValidAmount  = float.TryParse(amountText, out float amount);


            if (isValidAmount == false)
            {

                Console.Write("You have entered an invalid number. Please try again:");
                Console.ReadLine();
                return;


                // amountText = Console.ReadLine();
            }
            else if (amount < 0)
            {
                Console.Write("You have entered an number less than 0. Please try again:");
                Console.ReadLine();
                return;
            }




            Console.Write("Enter in the interest rate:");
            string interestText = Console.ReadLine();
            bool interestToInt = float.TryParse(interestText, out float interest);

            if (interestToInt == false)
            {
                Console.Write("You have entered an invalid number. Please try again:");
                Console.ReadLine();
                return;
            } else  if (interest < 0)
            {
                Console.Write("You have entered an number less than 0. Please try again:");
                Console.ReadLine();
                return;
            }




            //Calculate Interest on deposit
            float calculatedInterest = (amount / 100) * interest;
            float calculatedFullAmount = (amount + calculatedInterest);
            Console.WriteLine($"At an interest rate of {interest}% the amount interest on a deposit of £{amount} is £{calculatedInterest} which gives you a total of £{calculatedFullAmount}.");
        

    
    Console.ReadLine();

            }//end of main
    }//end of program
}
