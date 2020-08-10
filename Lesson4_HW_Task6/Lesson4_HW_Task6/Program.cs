using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HW_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Досвід роботи працівника.\n");
            Console.Write("Введіть клькість років: ");
            string exp = Console.ReadLine();
            byte expYears = Convert.ToByte(exp);

            if (expYears < 5)
            {
                Console.WriteLine("Ваша премія становить 10% від з/п!");
            }
            else if (expYears >= 5 && expYears < 10)
            {
                Console.WriteLine("Ви працюєте {0} років.Ваша премія становить 15% від з/п!", expYears);
            }

            else if (expYears >= 10 && expYears < 15)
            {
                Console.WriteLine("Ви працюєте {0} років.Ваша премія становить 25% від з/п!", expYears);
            }

            else if (expYears >= 15 && expYears < 20)
            {
                Console.WriteLine("Ви працюєте {0} років.Ваша премія становить 35% від з/п!", expYears);
            }
            else if (expYears >= 20 && expYears < 25)
            {
                Console.WriteLine("Ви працюєте {0} років.Ваша премія становить 45% від з/п!", expYears);
            }
            else if (expYears >= 25)
            {
                Console.WriteLine("Ви працюєте {0} років.Ваша премія становить 50% від з/п!", expYears);
            }
            Console.ReadKey();

        }
    }
}
