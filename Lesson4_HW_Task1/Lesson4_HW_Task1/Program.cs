using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HW_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число:");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && (n & (n - 1)) == 0)

            {
                Console.WriteLine("Число {0} є ступенем двійки",n);
            }

            else
            {
                Console.WriteLine("Число {0} не є ступенем двійки",n);
            }

            Console.ReadKey();

        }
    }
}
