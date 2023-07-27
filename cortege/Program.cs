using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cortege
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            
            return result;

        }
        static int[] SortArray(int[] result)
        {
            for (int j = 0; j < result.Length; j++)
            {
                for (int h = j + 1; h < result.Length; h++)
                {
                    if (result[j] > result[h])
                    {
                        int Variable = result[j];
                        result[j] = result[h];
                        result[h] = Variable;
                    }
                }
            }
            return result;
        }
        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if(IsSort)
            {
                temp = SortArray(array);
            }
            foreach (int i in temp)
            {
                Console.WriteLine(i);
            }
            
        }

        static void Main(string[] args)
        {

            var array = GetArrayFromConsole(3);
            ShowArray(array, true);

            Console.ReadKey();
        }
    }
}


