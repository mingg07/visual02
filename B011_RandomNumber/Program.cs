using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B011_RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[] num = new int[16];

            // 16개의 중복되지 않는 랜덤 숫자를 저장한다
            for (int i = 0; i < 16; i++)
            {
                //num[i] = Check();  // 1개씩 나옴
                num[i] = Check() % 8;  // 2개씩 나옴
            }

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(num[i]);
            }                
        }

        // static은 객체가 만드어져야 있는 것이 아니고 무엇을 쓰던간에 static을 써야 함
        static bool[] check = new bool[16];

        // 중복되지 않은 랜덤 값을 리턴하는 메서드
        private static int Check()
        {
            Random r = new Random();

            while (true)
            {
                int x = r.Next(16);  // 0 ~ 15
                if(check[x]==false)
                {
                    check[x] = true;
                    return x;
                }
            }  
        }
    }
}
