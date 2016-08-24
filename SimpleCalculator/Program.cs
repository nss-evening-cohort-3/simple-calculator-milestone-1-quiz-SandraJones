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
            int i = 0;
            int j = 0;
            RegexParser parser = new RegexParser();
            Evaluator eval = new Evaluator();
            Stack stackList = new Stack();
            bool keepLooping = true;
            while (keepLooping)
            {
                string prompt = "[" + i + "]>";
                Console.WriteLine(prompt + "Enter your math expression, ( eg. 3 + 5), here to calculate, or type exit or quit to stop the application.");
                userInput = Console.ReadLine();
                if (userInput == "quit" || userInput == "exit")
                {
                    keepLooping = false;
                    continue;
                }
                
                else if (userInput == "last")
                {                    
                            Console.WriteLine(stackList.answerList.Last());                    
                }
                else if (userInput == "lastq")
                {
                    //call a method from the stack class here
                    //print the last entered command;
                    //storing last userInput;
                    Console.WriteLine(userInput);
                }
                else
                {
                    try
                    {
                        parser.ParseInput(userInput);
                        int answer = eval.Calculate(parser);
                        Console.WriteLine(answer);

                        //add this answer to the end of the answerList 
                        //answerList keeps a running List of answers generated
                        stackList.AddToListOfAnswers(answer);

                    }                       
                    catch(Exception e)//can have multiple catch blocks to catch lower level exceptions
                    {
                        Console.WriteLine(e.Message);
                    }
                    i++;//this line is where my counter increments
                }
            }
        }
    }
}