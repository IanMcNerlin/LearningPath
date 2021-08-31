using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleUIConditionalsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {


// Create a Console Application thats asks the animal for their name. If they are a lion welcome them by their name and as King, everthing else as an animal

            Console.Write("What type of animal are you: ");
            string animalName = Console.ReadLine();

            if (animalName.ToLower() == "lion")
            {
                Console.WriteLine("Welcome King!");
            }
            else
            {
                Console.WriteLine("Welcome animal.");
            }

            Console.WriteLine("The application is finished.");

            Console.ReadLine();



// Using if else statements, create a Console Application thats asks the user to enter a number between 1 and 4 and print the corresponding number out to the screen. 
           

            Console.Write("Enter a number between 1 and 4:");
            int numberEntered = Convert.ToInt32( Console.ReadLine());

            if (numberEntered == 1)
            {
                Console.WriteLine($"The number entered is: {numberEntered}");
            }
            else if (numberEntered == 2)
            {
                Console.WriteLine($"The number entered is: {numberEntered}");
            }
            else if (numberEntered == 3)
            {
                Console.WriteLine($"The number entered is: {numberEntered}");
            }
            else if (numberEntered == 4)
            {
                Console.WriteLine($"The number entered is: {numberEntered}");
            }
            else
            {
                Console.WriteLine($"The number entered is not between 1 and 4. ");
            }

            Console.WriteLine("The application is finished.");
            Console.ReadLine();


            // Using  a switch statement, create a Console Application thats asks the user to enter a number between 1 and 4 and print the corresponding number out to the screen. 

            Console.Write("Enter a number between 1 and 4:");
            int numberIn = Convert.ToInt32(Console.ReadLine());

            switch (numberIn)
            {


                case 1:
                    Console.WriteLine($"You entered {numberIn}");
                    break;

                case 2:
                    Console.WriteLine($"You entered {numberIn}");
                    break;

                case 3:
                    Console.WriteLine($"You entered {numberIn}");
                    break;

                case 4:
                    Console.WriteLine($"You entered {numberIn}");
                    break;

                default:
                    Console.WriteLine($"You entered {numberIn}. It is not in range.");
                    break;
            }

            Console.WriteLine("The application is finished.");
            Console.ReadLine();

            //Using  a switch statement, create a Console Application that asks the user to enter a character and reports whether the entered character is a vowel or a consonant.

            string charEntered;
            Console.Write("Enter a character: ");
            charEntered = Console.ReadLine();
            
            switch (charEntered.ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("The character entered is a vowel");
                    break;

                default:
                    Console.WriteLine("The character entered is a consonant");
                    break;
            }
            Console.WriteLine("The application is finished.");
            Console.ReadLine();


            //Create a Console Application that asks the user to enter the available quantity of a product. If the available quantity is less than 200, the quantity to be ordered for the product is 650; otherwise, it’s 300
            //This modified example shows the different way to write the content of variables using WriteLine
            //The second part shows the use of the conditional operator, also known as the ternary operator
            //Should the if-else statement has a single statement to execute depending on the outcome of the logical expression. You can replace the preceding if-else statement with the conditional operator, 
            //logical expression? statement1: statement2;
            //where statement1 is executed if the logical expression is true; otherwise, statement2 is  executed.


            int quantityAvailable;
            int quantityOrdered;

            Console.Write("Enter available quantity: ");

            quantityAvailable = Convert.ToInt32(Console.ReadLine());

            if (quantityAvailable < 200)
            {
                quantityOrdered = 650;
            }
            else
            {
                quantityOrdered = 300;
            }         

            Console.WriteLine("Available Quantity: {0} and Ordered Quantity: {1}", quantityAvailable, quantityOrdered); //output confirms that the format specifiers {0} and {1} are replaced by the values of the variables quantityAvailable and quantityOrdered, respectively
            quantityOrdered = quantityAvailable < 200 ? 650 : 300; //If quantityAvailable < 200 evaluates to true, quantityOrdered = 650; otherwise, if false quantityOrdered = 300 is executed 

            Console.WriteLine("Press enter to see ternary operator.");
            Console.ReadLine();

            Console.WriteLine("Available Quantity: {0} and Ordered Quantity: {1}", quantityAvailable, quantityOrdered);

            Console.WriteLine("The application is finished.");
            Console.ReadLine();

            //Create a Console Application that asks the user to  enter in a number and check if it is odd or even
            //Thsi example uses the modulus and ternary oeprator whne writing output to Console 

            int numberInput;
            Console.Write("Enter a number: ");
            numberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberInput % 2 == 0 ? "Number is an even number" : "Number is an odd number"); // % 2 shows that remainderof dividing by 2 is 0 if it is write to console it even if not write out that it is odd
            
            Console.WriteLine("The application is finished.");
            Console.ReadLine();

        }//end of main




    }//end of program
    
}//end of namespace
