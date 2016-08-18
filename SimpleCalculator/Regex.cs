using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Regex
    {
        public int Term1 { get; set; }
        public int Term2 { get; set; }
        public int Operator { get; set; }

        private string pattern = @"^(-?\d+)\s*([+-*\/\%*])\s*(-?\d+)$";
        public void ParseInput(string userInput)
        {
            Match match = Regex.Match(userInput, pattern);
            if (match.Success)
            {
                Term1 = int.Parse(match.Groups[1].Value);
                Term2 = int.Parse(match.Groups[3].Value);
                Operator = match.Groups[2].Value[0];
            }
            else
            {
                throw new ArgumentException("Please enter a valid integer.");
            }
        }

        private static Match Match(string userInput, string pattern)
        {
            throw new NotImplementedException();
        }
    }
}
