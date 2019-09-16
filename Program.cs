using System;

namespace Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?: ");
            string first = Console.ReadLine();

            Console.Write("What is your Last name?: ");
            string last = Console.ReadLine();

            Console.Write("What tempature in Fahrenheit do you wnat to convert?: ");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Method_2(temp, first, last);
        }
        private static void Method_2(double temp, string first, string last)
        {
            Console.WriteLine("Hello " + first + " " + last + "!");
            double celsius = (temp - 32) * 5 / 9;
            Console.WriteLine("The tempature " + temp + " degrees Fahrenheit in Celsius is: " + celsius);
        }
    }
}
