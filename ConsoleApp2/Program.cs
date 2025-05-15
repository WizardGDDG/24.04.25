using System;
using static System.Console;

namespace MyNameSpace 
{
    static class MyClass
    {
        // 1 Задание
        static int Rectangle(int A, int B, int C)
        {
            if (C > A | C > B)
            {
                Console.WriteLine("Ошибка");
                return 0;
            }
            else
            {
                int sum = A * B;
                return sum /= C;
            }


        }
        // 2 Задание
        static void Bank() 
        {
            int P;
            int k = 0;
            int s = 10000;
            do
            {
                P = Convert.ToInt32(Console.ReadLine());
            } while (P<0 | P > 25);

            while (s < 11000) 
            {
                s += s / 100 * P;
                k++;
            }
            
            Console.WriteLine(s);
            Console.WriteLine(k);
        }
        // 3 Задание
        static void vivod(int a,int b) 
        {
            int c = 0;
            if (a < b) 
            {
                for (int i = a; i <= b; i++) 
                {
                    while (c != i) 
                    {
                        c++;
                        Console.Write(i);
                        
                    }
                    Console.WriteLine();
                    c = 0;
                }
            }
        }
        // 4 Задание
        static int dwd(int n) 
        {
            string s = n.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            n = Convert.ToInt32(s);
            return n;
        }
        static void Main(string[] args) 
        {

             
        }
 
            
    }
}


