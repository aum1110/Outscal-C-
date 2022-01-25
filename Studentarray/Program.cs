using System;

namespace Studentarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[n];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            
            }

            Array.Sort(students);
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            
            
            
            }





        }
    }
}
