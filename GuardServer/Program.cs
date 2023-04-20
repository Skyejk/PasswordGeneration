using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guard PRO Terminal server application.");
            switch (Console.ReadKey())
            {
                case "1":
                    Console.WriteLine();
                    break;
                default: Console.WriteLine();
                    break;
            }
            
        }
    }
}
