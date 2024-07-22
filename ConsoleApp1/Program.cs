using System;
using System.Collections.Generic;
using System.Linq;
TestWM Test 1
bill goes hereM Test 1
WRM 2
master M Test 1
wrm2
    
cs test 2
    cs3
master
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myNumbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            var number = myNumbers.Where(n => n > 5);
            foreach (var item in number )
            {
                //Console.WriteLine($" This is {item}");
                item.ToString().PrintToConsole();
            }
            Console.WriteLine("**************************");
             Console.WriteLine("**************************");

            Console.ReadLine();
        }        
    }

    public static class Extensions
    {
        public static void PrintToConsole(this String message)
        {
            Console.WriteLine(message);
            //v1
            // V2
          
        }
    }

}
