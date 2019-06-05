using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A023_ListAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            //int a = r.Next();   // 32bit의 정수만
            //int b = r.Next(100);   //0~100
            //int c = r.Next(10, 20);   //10~20
            //double d = r.NextDouble();   //0~1 사이 소수

            //Console.WriteLine(a.ToString() + ", " + b.ToString() + ", " + c.ToString() + ", " + d.ToString());

            //string s = string.Format($"{a}, {b}, {c}, {d}");
            //Console.WriteLine(s);

            //string t = string.Format("{0}, {1}, {2}, {3}", a, b, c, d);
            //Console.WriteLine(t);

            //string u = string.Format("{0,10}, {1,10}, {2,10}, {3,10:F3}", a, b, c, d);
            //Console.WriteLine(u);

            //랜덤한 a,b,c,d를 10번 만들어 출력
            //Random r = new Random();

            //for (int i = 0; i < 10; i++)
            //{ 
            //    int a = r.Next();   // 32bit의 정수만
            //    int b = r.Next(100);   //0~100
            //    int c = r.Next(10, 20);   //10~20
            //    double d = r.NextDouble();   //0~1 사이 소수
            //    Console.WriteLine("{0,10}, {1,10}, {2,10}, {3,10:F3}", a, b, c, d);
            //}

            // 두 개의 주사위를 100번 던져서 숫자의 합이 몇 개인지
            //Random r = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    int a = r.Next(1, 7);
            //    int b = r.Next(1, 7);

            //    int c = a + b;

            //    Console.WriteLine(c);
            //}

            // 두 개의 주사위를 1000000번 던져서 각각의 합이 몇 번씩
            // 나왔는지를 출력하시오
            //Random r = new Random();

            //int[] cnt = new int[13];

            //for (int i = 0; i < 1000000; i++)
            //{
            //    cnt[r.Next(1, 7) + r.Next(1, 7)]++;
            //}

            ////for (int j = 0; j < 12; j++)
            ////{
            ////    console.writeline(cnt[j]);
            ////}

            //for (int k = 2; k <= 12; k++)
            //{
            //    Console.WriteLine("{0, 2} : {1}", k, cnt[k]);
            //}

            //Console.WriteLine("foreach array");
            //foreach (var item in cnt)
            //{
            //    Console.WriteLine(item);
            //}

            // list는 크기가 정해져있지 않은 것이 장점
            // list : Generic <T> List<T>
            //Random r = new Random();
            //List<int> lst = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    lst.Add(r.Next(100));

            //}
            //foreach (var item in lst)   // list랑 짝궁
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("for array");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(lst[i]);   // 마치 배열처럼
            //}

            // 10개짜리 문자열 배열 s1과 문자열 리스트 s2를 만드시오
            string[] s1 = new string[10];
            List<string> s2 = new List<string>();

            // 문자열 10개를 콘솔에서 입력받아 배열과 리스트에 저장하시오
            Console.WriteLine("문자열 10개를 입력하세요");
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                s1[i] = s;
                s2.Add(s);
            }

            // 문자열 10개를 출력
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} {1,20}", s1[i], s2[i]);
            }

            // 정렬하여 출력하기
            Array.Sort(s1);   // 배열
            s2.Sort();   // 리스트

            Console.WriteLine("배열과 리스트 정렬 후 출력");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} {1,20}", s1[i], s2[i]);
            }
        }
    }
}
