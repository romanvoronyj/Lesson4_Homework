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
            bool A = true;
            bool B = false;
            // до теореми Моргана
            if (A | B)
                Console.WriteLine("A|B {0}", A | B);
            else
                Console.WriteLine("A|B {0}", A | B);
            // після її застосування
            if (!(!A & !B))
                Console.WriteLine("!(A&!B) {0}",!(!A & !B));
            else
                Console.WriteLine("!(A&!B) {0}", !(!A & !B));

            Console.ReadKey();




        }
    }
}
