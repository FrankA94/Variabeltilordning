using System;

namespace Variabeltilordning
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string stringVar = "halla";
            char charVar = 'A';
            int a = 3;
            float floatVar = 10.2f;
            long longVar = 10000L;
            decimal b = 3.0m;
            double doubleVar = 10;
            bool boolVar = true;
            decimal sum = a + b;

            Console.WriteLine(a+b);
            Console.WriteLine(sum);
        }
    }
}
