using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cortege
{
    internal class Program
    {
            static string GetDataFromConsole() => Console.ReadLine();
        static string ShowColor()
        {
            string color = Console.ReadLine();
            return color;
        }
        static void Main(string[] args)
        {
            string[] favcolor = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Напишите цвет {i + 1}");
                favcolor[i] = ShowColor();
            }
            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}


