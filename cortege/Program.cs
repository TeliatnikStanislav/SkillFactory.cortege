using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cortege
{
    internal class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
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
            foreach (int g in result)
            {
                Console.WriteLine(g);
            }
            return result;

        }
        static string ShowColor()
        {

            string color = Console.ReadLine();
            return color;
        }
        static void Main(string[] args)
        {
            GetArrayFromConsole();
            Console.ReadKey();
        }
    }
}


