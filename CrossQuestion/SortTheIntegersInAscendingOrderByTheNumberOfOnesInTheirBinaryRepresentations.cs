using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 3, 1, 2, 3 };
            int[] res = arrange(array);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("###################### Second ###############################");
            int[] array1 = new[] { 5, 5, 3, 7, 10, 14 };
            int[] res1 = arrange(array1);
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static string DecimalToBinary(int value)
        {
            return Convert.ToString(value, 2);
        }

        public static int BinaryToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static int[] arrange(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (DecimalToBinary(numbers[i]).Where(x => x == '1').Count() < DecimalToBinary(numbers[j]).Where(x => x == '1').Count())
                    {
                        continue;
                    }
                    else if (DecimalToBinary(numbers[i]).Where(x => x == '1').Count() == DecimalToBinary(numbers[j]).Where(x => x == '1').Count())
                    {
                        if (numbers[i] > numbers[j])
                        {
                            int temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                    else
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }


                }
            }
            return numbers.Distinct().ToArray();
        }
    }
}
