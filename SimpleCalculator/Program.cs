using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        private static int number;
        private static string prompt;
        private string i;
        static void Main(string[] args)
        {
            //while user is interacting, perform requested calculator functions
            // while (userInput != 0)
            //create prompt and increment prompt with each completed task
            //first user input begins here
            Console.WriteLine("Hello! Welcome to Simple Calculator. Which math function would you like to do? We offer" + " Addition" + "," + " Subtraction"+ "," + " Modulo" +"," + " Multiplication" +"," + " and" +  " Division"+".");
            //some kind of search to match against these strings or use switch and cases.
            Console.WriteLine("Write a number for u.");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a number for v.");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("["+ "i" +"]", prompt);
            String userInput1 = Console.ReadLine().ToLower();
            String switchToInt = Console.ReadLine();
            bool intNow = false;
            intNow = (Int32.TryParse(switchToInt, out number));
            int t = Convert.ToInt32(Console.ReadLine());
            switch (t)
            {
                case 1: Addition:
                    //Addition
                    Console.Write(Addition.AddTwoNumbers(u, v));
                    break;
                case 2: Subtraction:
                    //Subtraction
                    Console.Write(Subtraction.SubtractTwoNumbers(u, v));
                    break;
                case 3: Multiplication:
                    //Multiplication
                    Console.Write(Multiplication.MultiplyTwoNumbers(u, v));
                    break;
                case 4: Modulo:
                    //Modulo
                    Console.Write(Modulo.ModuloTwoNumbers(u, v));
                    break;
                case 5: Division:
                    //Division
                    Console.Write(Division.DivideTwoNumbers(u, v));
                    break; 
            }
            Console.ReadKey(true);
        }
            //exit the while loop using 'return;'
    }
}
