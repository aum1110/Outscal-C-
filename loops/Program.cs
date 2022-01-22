using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();

            double roll1= 0;
            double roll2 = 0;
            int attempts = 0;
            Console.WriteLine(" Press Enter To Roll The Dice : ");
            while (roll1!= 6 && roll2 != 6)
                {
               
                    Console.ReadKey();
                    roll1 = number.Next(1, 7);
                    roll2 = number.Next(1, 7);
                    Console.WriteLine("Roll1 Number is : " + roll1);
                    Console.WriteLine("Roll2 Number is : " + roll2 );
                    attempts++;
                }
                

            Console.WriteLine("Number of Attempts took : " + attempts);


        }
    }
}
