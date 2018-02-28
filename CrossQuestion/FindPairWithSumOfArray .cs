using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossQuestion
{
    class FindPairWithSumOfArray
    {
        static void Main(String[] args)
        {
            string res = "";

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Convert.ToInt32(Console.ReadLine());
                _a[_a_i] = _a_item;
            }
            int sum = Convert.ToInt32(Console.ReadLine());
            res = FindIndexOfSum(_a, sum);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        static string FindIndexOfSum(int[] _a, int sum)
        {
            string Index = "";
            for (int i = 0; i < _a.Length; i++)
            {
                if (!string.IsNullOrEmpty(Index))
                {
                    break;
                }
                for (int j = 1; j < _a.Length; j++)
                {
                    if (_a[i] + _a[j] == sum)
                    {
                        Index = i + " " + j;
                        break;
                    }
                }
            }
            return Index;
        }
    }
}
