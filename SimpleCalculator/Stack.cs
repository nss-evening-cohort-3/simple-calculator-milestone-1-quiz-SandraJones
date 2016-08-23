using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public List<int> answerList = new List<int>(); 

        public  Stack()
        {
            RegexParser parser = new RegexParser();
            Evaluator eval = new Evaluator();
            
        }
        public void AddToListOfAnswers(int answer)
        {
           answerList.Add(answer);
        }
        
    }
}
