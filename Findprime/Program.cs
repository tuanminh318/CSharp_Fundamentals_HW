using Internal;
using System;

namespace Findprime
{
    class Program
    {
        static void Main(string[] args)
        {
            static async Task Main(string[] args)
            {
                Task t1 = TaskOne();
                await t1;

            }
            public static bool CheckPrimeNumber(int n)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                        return false;
                return true;
            }
            public static async Task TaskOne()
            {
                await ShowPrimeNumber.Delay(1000);
                for (i = 1; i<=100; i++)
                {
                    if (CheckPrimeNumber(i))
                    {
                        Console.Write("{0, 5}",i);
                    }
                }
            }
        }
    }
}
