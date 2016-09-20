using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constants
    {
        private Dictionary<char, int> storeConstantsDictionary = new Dictionary<char, int>();
        public void UserCreateAConstToAddToDictionary(char key, int value)
        {
           
            
            if (storeConstantsDictionary.ContainsKey(key))
            {
                throw new ArgumentException("That constant already exists.");
            }
            else
            {
                storeConstantsDictionary.Add(key, value);//.Add(key, value)
            }
        }
        public int ReturnValueOfConstant(char key)
        {
            return storeConstantsDictionary[key];
        }

    }
}
