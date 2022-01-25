using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> shoppinglist = new List<string>();

            shoppinglist.Add("Dreams");
            shoppinglist.Add("Games");
            shoppinglist.Add("PS5");
            shoppinglist.Add("XboX");


            for (int i = 0; i< shoppinglist.Count; i++)
            {
                Console.WriteLine(shoppinglist[i]);
            }

            shoppinglist.Remove("Games" 
                );
            shoppinglist.RemoveAt(2);


            Console.WriteLine("---------------------------------------");


            for (int i = 0; i < shoppinglist.Count; i++)
            {
                Console.WriteLine(shoppinglist[i]);
            }











        }
    }
}
