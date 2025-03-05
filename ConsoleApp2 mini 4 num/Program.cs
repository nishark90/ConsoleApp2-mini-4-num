using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_mini_4_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c && a > d)
            { Console.WriteLine("The grater number is :" + a); }
            else if (b > c && b > d)
            { Console.WriteLine("The grater number is :" + b); }
            else if (c > d)
            { Console.WriteLine("The grater number is :" + c); }
            else
            { Console.WriteLine("The grater number is :" + d); }

            Console.ReadKey();
        }
        
    }
}
