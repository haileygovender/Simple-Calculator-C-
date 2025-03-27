using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables being declared
            int calculationValue = 0;
            string operationOption;
            bool value = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, Welcome to the calculator program!");
            Console.WriteLine("//////////////////////////////////////////");

            //Keep lopping until user decides to exist
            while (value)
            {
                Console.WriteLine("\nPlease enter your first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease enter your second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease enter 'a' for addition, 's' for substraction, m for multiplication or any other key for division.");
                operationOption = Console.ReadLine().ToLower();

                if (operationOption == "a")
                {
                    calculationValue = firstNumber + secondNumber;
                }
                else if (operationOption == "s")
                {
                    calculationValue = firstNumber - secondNumber;
                }
                else if (operationOption == "m")
                {
                    calculationValue = firstNumber * secondNumber;
                }
                else
                {
                    //handle division by Zero
                    if(secondNumber ==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                        continue; // Skip further steps and restart the loop
                    }
                    calculationValue = firstNumber / secondNumber;
                }

                Console.WriteLine("//////////////////////////////////////////");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nYour total amount: {calculationValue}");
                Console.WriteLine("//////////////////////////////////////////");

                //ask if the user wants to exit or perform another calculation
                Console.WriteLine("\n Do you want to perform another calculation? (Y to continue or any other key to exit)");
                string userChoice = Console.ReadLine().ToUpper();

                if (userChoice !="Y")
                {
                    Console.WriteLine("\nThank you for using the caculator program. Gooddbye!");
                    value = false; // exit the loop
                }
            }
            Console.ReadLine();
        }
    }
}
