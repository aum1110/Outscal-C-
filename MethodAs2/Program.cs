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


            if (answer % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
                    
            }

        }

        static int Multiply(int a, int b, int c)
        {

            int result = a * b * c;
            return result;

        }


    }
}