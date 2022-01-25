using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentance : ");

            string str = Console.ReadLine();
            int wordcount = Worrd(str);

            Console.WriteLine("There are " + wordcount + "Words in the sentence" );


           
        }

        static int Worrd(string str)
        {
            int wordcount = str.Split(' ').Length;
            return wordcount;
        
        }



















       /*static void MeetAlien()
        {
            Random numbergen = new Random();
            string name = "X-" + numbergen.Next(10, 99999);

            int age = numbergen.Next(10, 500);

            Console.WriteLine("HI i am \n" + name  + "My age is \n "  + age);
            Console.WriteLine("oh and i am an alien");
        
        }*/

    }
}
