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
            if (storeConstantsDictionary.ContainsKey(key))
            {
                return storeConstantsDictionary[key];
            }
            else
            {
                throw new ArgumentException("You are free to set that constant by entering it in this form:  v = 45, with the variable on the left and the value to the right of the equals sign.");
            }     
        }

    }
}
