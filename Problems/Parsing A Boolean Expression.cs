using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public partial class Solution
    {
        public bool ParseBoolExpr(string expression)
        {
            var stack = new Stack<char>();
            foreach (var c in expression)
            {
                if (c == ')')
                {
                    var list = new List<char>();
                    while (stack.Peek() != '(')
                    {
                        list.Add(stack.Pop());
                    }
                    stack.Pop(); // Pop '('
                    var op = stack.Pop(); // Pop operator
                    if (op == '!')
                    {
                        stack.Push(list[0] == 't' ? 'f' : 't');
                    }
                    else if (op == '&')
                    {
                        stack.Push(list.All(x => x == 't') ? 't' : 'f');
                    }
                    else if (op == '|')
                    {
                        stack.Push(list.Any(x => x == 't') ? 't' : 'f');
                    }
                }
                else if (c != ',')
                {
                    stack.Push(c);
                }
            }
            return stack.Pop() == 't';
        }
    }
}
