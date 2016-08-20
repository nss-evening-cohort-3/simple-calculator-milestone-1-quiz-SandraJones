using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int number;
            int i = 0;
            RegexParser parser = new RegexParser();
            Evaluator eval = new Evaluator();
            bool keepLooping = true;
            while (keepLooping)
            {
                string prompt = "[" + i + "]";
                Console.WriteLine(prompt, "Enter your math ( eg. 3 + 5) expression here to calculate.");
                userInput = Console.ReadLine();
                if (userInput == "quit" || userInput == "exit")
                {
                    keepLooping = false;
                    continue;
                }
                else if (userInput == "last")
                {
                    //print the last whatever;
                }
                else if (userInput == "lastq")
                {
                    //print the lastq thing;
                }
                else
                {
                    try
                    {
                        parser.ParseInput(userInput);
                        int answer = eval.Calculate(parser);
                        Console.WriteLine(answer);
                    }
                    catch(Exception e)//can have multiple catch blocks to catch lower level exceptions
                    {
                        Console.WriteLine(e.Message);
                    }
                    i++;
                }
            }
        }
    }
}