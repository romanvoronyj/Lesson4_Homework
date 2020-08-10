using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HW_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            x+= y >> x++ * z;
            Console.WriteLine("x={0};",x);

            x = 5; y = 10; z = 15;
            z = ++x & y * 5;
            Console.WriteLine("z={0};", z);

            x = 5; y = 10; z = 15;
            y /= x + 5 | z; 
            Console.WriteLine("y={0};", y); // y=0?

            x = 5; y = 10; z = 15;
            z = x++ & y * 5;
            Console.WriteLine("z={0};", z);

            x = 5; y = 10; z = 15;
            x = y << x++ ^ z;
            Console.WriteLine("x={0};", x);

            x = 5; y = 10;
            x = y << 5;
            Console.WriteLine("x={0};", x);

            Console.ReadKey();
        }
    }
}
