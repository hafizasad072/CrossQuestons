using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerAlgo
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<string> expressions = new List<string>();

            for (int tItr = 0; tItr < t; tItr++)
            {
                expressions.Add(Console.ReadLine());
            }
            checkAll(expressions);
            Console.ReadLine();
        }
        static void checkAll(List<string> expressions)
        {
            foreach (var exp in expressions)
            {
                Console.WriteLine(IsBalance(exp) ? "Yes" : "No");
            }
        }
        static bool IsBalance(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return false;

            List<string> brackets = new List<string> { "()", "[]", "{}" };
            var pairedbrackets = brackets.ToDictionary(x => x[0], x => x[1]);

            Func<char, bool> IsBracket = b => pairedbrackets.ContainsKey(b) || pairedbrackets.ContainsValue(b);

            Stack<char> stack = new Stack<char>();
            foreach (var c in expression.Where(IsBracket))
            {
                bool isopening = pairedbrackets.ContainsKey(c);

                var pair = isopening ? pairedbrackets[c] : pairedbrackets.First(x => x.Value == c).Key;

                if (isopening)
                {
                    stack.Push(c);
                }
                else
                {
                    if (!stack.Any())
                        return false;
                    else if (stack.Peek() != pair)
                        return false;

                    stack.Pop();
                }
            }
            return !stack.Any();
        }
    }
}
