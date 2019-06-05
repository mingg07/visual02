using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A002_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;

            Console.WriteLine(x.ToString() + ", " + y.ToString());   // or (x + ", " + y)
            // printf("%d %d", x, y);
            Console.WriteLine("{0}, {1}", x, y);
            Console.WriteLine($"{x}, {y}");   // $는 변수 값으로 인식

            string s = string.Format($"{x}, {y}");
            Console.WriteLine(s);

            string t = string.Format("{0}, {1}", x, y);
            Console.WriteLine(t);
        }
    }
}
