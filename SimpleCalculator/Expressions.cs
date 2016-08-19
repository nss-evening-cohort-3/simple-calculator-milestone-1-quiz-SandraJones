using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expresssions
    {
        
        public string userResponse;
        //*************WORKING ON THIS ******************
        //possibly use String.Comparer 

        public StringComparer OrdinalIgnoreCase {get;}
        private string quit = "quit";
        private string exit = "exit";
        private string last = "last";
        private string lastq = "lastq";

        // public void Match(string userResponse)
        //{
        //    Match match = Expressions.Match(userResponse)
        //    if (userResponse = "quit")
        //     {
        //         break;
        //     } else if (userResponse = "exit")
        //     {
        //         break;
        //     } else if (userResponse = "last")
        //     {
        //         Console.WriteLine("Last Printed Answer");
        //     } else if (userResponse = "lastq")
        //     {
        //         Console.WriteLine("Last printed command or expression.")
        //     }


        //        Term1 = int.Parse(match.Groups[1].Value);
        //        Term2 = int.Parse(match.Groups[3].Value);
        //        Operator = match.Groups[2].Value[0];
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Please enter a valid integer.");
        //    }
        //}



        int AddTwoNumbers(int number1, int number2)
      {
            return number1 + number2;
      }
      int SubtractTwoNumbers(int number1, int number2)
      {
          return number1 - number2;
      }
      int MultiplyTwoNumbers(int number1, int number2)
      {
           return number1 * number2;
      }
      int ModuloTwoNumbers(int number1, int number2)
      {
           return number1 % number2;
      }
      int DivideTwoNumbers(int number1, int number2)
      {
           return number1 / number2;
      }

        //internal static string ModuloTwoNumbers(int u, int v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static string DivideTwoNumbers(int u, int v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static string MultiplyTwoNumbers(int u, int v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static string SubtractTwoNumbers(int u, int v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static string AddTwoNumbers(int u, int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
    
}
