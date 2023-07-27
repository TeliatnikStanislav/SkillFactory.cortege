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
        static string ShowColor(string username)
        {
            Console.WriteLine($"Напишите свой любимый цвет на английском с маленькой буквы, {username}");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Ваше имя: {anketa.name}");
            Console.WriteLine($"Ваш возраст: {anketa.age}");

            var favcolors = new string[3];

            for(int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(anketa.name); 
            }
            Console.ReadKey();
        }
    }
}


