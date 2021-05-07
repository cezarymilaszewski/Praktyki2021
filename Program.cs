using System;
using System.Security.Cryptography.X509Certificates;

namespace zadanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new calculator(21, 12);

            Console.WriteLine(calculator.Add());

        }
    }
}
