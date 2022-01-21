using System;

namespace rollercoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Amuesment Park");
            Console.WriteLine("TO enter the roller Coster ENter Your age Or Height:");

                int age = Convert.ToInt32(Console.ReadLine());
            int Height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && Height >= 170)
            {
                Console.WriteLine("You ARe Eligible");

            }
            else
            {

                Console.WriteLine("You Are Not Eligbile");
            
            }



                
        }
    }
}
