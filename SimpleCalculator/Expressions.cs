﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expressions
    {
        
      public string userResponse;
       
      public StringComparer OrdinalIgnoreCase {get;}
      public string quit = "quit";
      public string exit = "exit";
      public string last = "last";
      public string lastq = "lastq";

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
    }
    
}
