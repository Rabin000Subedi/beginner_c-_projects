using Microsoft.Win32.SafeHandles;

namespace calculator
{
class Calculator
    {
        public static void Main(string[] args)
        {
            int num1 ;
            int num2 ;
            string operation;


            System.Console.WriteLine("Hello! welcome to the calculator app");
            System.Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please select the operation you want to perform");
            System.Console.WriteLine("a. Addition");
            System.Console.WriteLine("s. Subtraction");
            System.Console.WriteLine("m. Multiplication");
            System.Console.WriteLine("d. Division");    

            operation = Console.ReadLine();

            if (operation == "a")
            {
                System.Console.WriteLine("The result of addition is: " + (num1 + num2));
            }
            else if (operation == "s")
            {
                System.Console.WriteLine("The result of subtraction is: " + (num1 - num2));
            }
            else if (operation == "m")
            {
                System.Console.WriteLine("The result of multiplication is: " + (num1 * num2));
            }
            else if (operation == "d")
            {
                System.Console.WriteLine("The result of division is: " + (num1 / num2));
            }
            else
            {
                System.Console.WriteLine("Invalid operation selected");
            }


        }


    }




}
