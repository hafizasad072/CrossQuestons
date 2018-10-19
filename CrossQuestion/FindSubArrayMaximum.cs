using System.Collections.Generic;
using System.Linq;
using System;

class program
{

    static int[] slidingmax(int[] elements, int k)
    {
        elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        k = 4;
        int j, max, n = elements.Length;
        List<int> result = new List<int>();
        for (int i = 0; i <= n - k; i++)
        {
            //max = elements[i];

            //for (j = 1; j < k; j++)
            //{
            //    if (elements[i + j] > max)
            //        max = elements[i + j];
            //}
            result.Add(elements.Skip(i).Take(k).Max());
            //Console.Write(max + " "); 
        }
        return result.ToArray();
    }
    // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

    static void Main(String[] args)
    {
        int[] res;


        var str = Console.ReadLine().Split(' ');
        int _elements_size = Convert.ToInt32(str[0]);
        int windowsize = Convert.ToInt32(str[1]);
        int[] _elements = new int[_elements_size];
        //int _elements_item;
        //for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
        //{
        //    _elements_item = Convert.ToInt32(Console.ReadLine());
        //    _elements[_elements_i] = _elements_item;
        //}

        res = slidingmax(_elements, windowsize);
        for (int res_i = 0; res_i < res.Length; res_i++)
        {
            Console.WriteLine(res[res_i]);
        }
        Console.ReadLine();
    }
}
