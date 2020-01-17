using System;
using TestNuget.Core;

namespace NugetClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Calculate();
            var res = cal.Add(20, 10);
            Console.WriteLine("res: " + res);
            Console.ReadKey();
        }
    }
}
