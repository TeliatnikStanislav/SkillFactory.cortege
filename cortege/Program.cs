using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cortege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();
            Console.WriteLine(User.Name);
            User.Dishes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите любимое блюдо номер {i + 1}");
                User.Dishes[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
