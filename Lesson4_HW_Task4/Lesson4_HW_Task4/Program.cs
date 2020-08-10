using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HW_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число:");
            int num = Int32.Parse(Console.ReadLine());

            if ((num & 1) == 0)//Прирівнюємо введене число до числа 1, в якого молодший біт=1
            {
                Console.WriteLine("Число парне.");
            }
            else
            {
                Console.WriteLine("Число непарне.");
            }

            if ((num<<(1&2)==0))
            {
                Console.WriteLine("Число парне.");
            }
            else
            {
                Console.WriteLine("Число непарне.");
            }
            Console.ReadKey();
        }
    }
}
