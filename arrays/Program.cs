using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];

            Console.WriteLine("Enter 4 Movies name : ");

            for (int i = 0; i <= movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\n Here they are in Alphabetically:");

            Array.Sort(movies);

            for (int i = 0; i <= movies.Length; i++)
                {

                Console.WriteLine(movies[i]);
            
            
                }








        }
    }
}
