using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        RegexParser parser = new RegexParser();
        Stack lastAnswer = new Stack();
        Evaluator eval = new Evaluator();
        List<int> answerList = new List<int>();
    }
}
