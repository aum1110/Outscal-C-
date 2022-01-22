using System;

namespace coolnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter till what MAx. amnt you want cool numbers : ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2 , i);
                Console.WriteLine(result);
                
            
            }

        }
    }
}
