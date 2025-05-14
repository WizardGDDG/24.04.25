using System;


namespace MyNameSpace 
{
    static class MyClass
    {
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

        static void Main(string[] args) 
        {
            

        }
 
            
    }
}


