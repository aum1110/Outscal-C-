using System;

namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Game !!!");

             Console.WriteLine(" Question 1 : 10 * 2 -2 + 5");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a1 == 23)
            { Console.WriteLine("Correct!"); }
            else { Console.WriteLine("Wrong"); }


            Console.WriteLine(" Question 2 : 36 - 5 + 12");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a2 == 23)
            { Console.WriteLine("Correct!"); }
            else { Console.WriteLine("Wrong"); }


            Console.WriteLine(" Question 3 : 20 - 5 + 5 + 3");
            int a3 = Convert.ToInt32(Console.ReadLine());
            if (a3 == 23)
            { Console.WriteLine("Correct!"); }
            else { Console.WriteLine("Wrong"); }

        }
    }
}
