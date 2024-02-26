using System;

namespace AddMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sum1 = Add(5, 10);
            Console.WriteLine("Sum of integers: " + sum1);

            
            decimal sum2 = Add(3.5m, 2.7m);
            Console.WriteLine("Sum of decimals: " + sum2);

            
            string result1 = Add(15, 8, true);
            Console.WriteLine("Result with boolean (true): " + result1);

            string result2 = Add(7, 3, false);
            Console.WriteLine("Result with boolean (false): " + result2);
        }

       
        static int Add(int a, int b)
        {
            return a + b;
        }

      
        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

       
        static string Add(int a, int b, bool includeDollars)
        {
            int sum = a + b;
            if (includeDollars)
            {
                string dollars = sum != 1 ? " dollars" : " dollar";
                return sum + dollars;
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}