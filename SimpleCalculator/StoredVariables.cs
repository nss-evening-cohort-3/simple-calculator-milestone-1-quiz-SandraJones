using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class StoredVariables
    {
        public StoredVariables myDictionary = new StoredVariables();
        //create the ability to enter a variable and assign it a value
        private string kvp = @"^([a-zA-Z]\s*(['='])\s*\d*)$";
        private Dictionary<char, int> variables = new Dictionary<char, int>();
    }
}