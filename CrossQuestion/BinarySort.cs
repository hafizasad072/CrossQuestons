using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinString
{
    class BinarySort
    {
        /*
        * Complete the function below.
        * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
        */
        static int[] rearrange(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    string M_binary = Convert.ToString(elements[i], 2), N_binary = Convert.ToString(elements[j], 2);
                    int mc = M_binary.Count(x => x == '1');
                    int nc = N_binary.Count(x => x == '1');
                    if (nc < mc)
                    {
                        int tmp = elements[i];
                        elements[i] = elements[j];
                        elements[j] = tmp;
                    }
                    else if (nc == mc)
                    {
                        int N_int = Convert.ToInt32(N_binary, 2);
                        int M_int = Convert.ToInt32(M_binary, 2);
                        if (N_int < M_int)
                        {
                            int tmp = elements[i];
                            elements[i] = elements[j];
                            elements[j] = tmp;
                        }
                    }
                }
            }
            return elements;

        }
        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main(String[] args)
        {
            int[] res;

            int _elements_size = 0;
            _elements_size = Convert.ToInt32(Console.ReadLine());
            int[] _elements = new int[_elements_size];
            int _elements_item;
            for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
            {
                _elements_item = Convert.ToInt32(Console.ReadLine());
                _elements[_elements_i] = _elements_item;
            }

            res = rearrange(_elements);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
            Console.ReadLine();
        }
    }
}

// if (M_binary == N_binary)
//                    {
//                        result[i] = Convert.ToInt32(M_binary, 2);
//                    }
//                    else
//                    {
//                        int mc = M_binary.Count(x => x == '1');
//int nc = N_binary.Count(x => x == '1');
//                        if (mc > nc)
//                        {
//                            result[i] = Convert.ToInt32(N_binary, 2);
//                        }
//                        else if (mc == nc)
//                        {
//                            int mint = Convert.ToInt32(M_binary, 2);
//int nint = Convert.ToInt32(N_binary, 2);
//                            if (mint > nint)
//                            {
//                                result[i] = nint;
//                            }
//                            else
//                            {
//                                result[i] = mint;
//                            }
//                        }
//                        else
//                        {
//                            result[i] = Convert.ToInt32(M_binary, 2);
//                        }

//                    }
//                    break;
