using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossQuestion
{
    class TwinString
    {
        static string[] twins(string[] a, string[] b)
        {
            string[] tempArray = new string[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                char[] text = a[i].ToCharArray();
                int legth = text.Length;
                for (int j = 0; j < text.Length; j++)
                {
                    if ((j % 2 == 0) && (j > 0))
                    {
                        j = j + 2;
                    }
                    if ((j + 2) <= legth - 1)
                    {
                        char temp = text[j];
                        text[j] = text[j + 2];
                        text[j + 2] = temp;
                    }
                }
                tempArray[i] = new string(text);
            }

            string[] result = new string[b.Length];
            for (int l = 0; l < b.Length; l++)
            {
                if (tempArray.Length - 1 >= l)
                {
                    if (tempArray[l] == b[l])
                    {
                        result[l] = "Yes";
                    }
                    else
                    {
                        result[l] = "No";
                    }
                }
                else
                {
                    result[l] = "No";
                }
            }


            return result;
        }

        // DO NOT MODIFY CODE BELOW THIS LINE!
        static void Main(String[] args)
        {
            string[] res;

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
            Console.ReadLine();
        }
    }
}
