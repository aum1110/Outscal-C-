using System;

namespace Methodas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers for multiplication : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int answer = Multiply(a, b, c);

            Console.WriteLine(answer);
            



        }

        static int Multiply(int a, int b, int c)
        {

            int result = a * b * c;
            return result;

        }


    }
}