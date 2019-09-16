using System;

namespace Deliverable_3___Methods
{
    class Program
    {
        //First Method
        static void Main(string[] args)
        {
           try
            {
                // Ask user for first name
                Console.Write("What is your first name?: ");
                string first = Console.ReadLine();

                // Ask user for last name
                Console.Write("What is your Last name?: ");
                string last = Console.ReadLine();

                // Ask user what temp they want to convert
                Console.Write("What tempature in Fahrenheit do you wnat to convert?: ");
                double temp = double.Parse(Console.ReadLine());
                // extra space
                Console.WriteLine("");

                // Method call and push 
                Method_2(temp, first, last);
            }
            catch (Exception ex)
            {
                // error message
                Console.WriteLine(ex.Message);
            }
            
        }
        // Second Method
        private static void Method_2(double temp, string first, string last)
        {
            // Output of first and last name
            Console.WriteLine("Hello " + first + " " + last + "!");
            // convert temps F to C
            double celsius = (temp - 32) * 5 / 9;
            // Output user temp and converted temp
            Console.WriteLine("The tempature " + temp + " degrees Fahrenheit in Celsius is: " + celsius);
        }
    }
}
