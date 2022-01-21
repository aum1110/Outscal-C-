using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {

            int avg;

            Console.WriteLine("Average Of Three Numbers");

            Console.WriteLine("Enter the First Number :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Number :");
            int c = Convert.ToInt32(Console.ReadLine());

            
            avg = a + b + c / 3;

            Console.WriteLine("The Average of Three Number is :" + avg);



        }
    }
}
