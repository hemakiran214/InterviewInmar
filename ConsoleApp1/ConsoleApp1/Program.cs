using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hemakiran for INMAR Interview");
            PrintFizzBuzz();
            ReverseTheString();
            Console.ReadKey();
        }

        public static void PrintFizzBuzz()
        {
            for(int i=1; i<=100; i++)
            {
                bool is3Multiple = i % 3 == 0;
                bool is5Multiple = i % 5 == 0;
                if (is3Multiple && is5Multiple)
                    Console.WriteLine("fizzbuzz");
                else if(is3Multiple)
                    Console.WriteLine("buzz");
                else if(is5Multiple)
                    Console.WriteLine("fizz");
            }
        }

        public static void ReverseTheString()
        {
            string mainString = "abcdef";
            StringBuilder sb = new StringBuilder();
            for(int i = mainString.Length - 1; i >= 0; i--)
            {
                sb.Append(mainString[i]);
            }
            Console.WriteLine("ReverseTheString - OUTPUT---------------------------------");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("---------------------------------");
        }
    }
}
