using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace HomeworkN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region N1 
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("N1");
            Console.WriteLine("Pick a number");
            var a = Convert.ToInt32(Console.ReadLine());
            List<int> listODD = new List<int>();
            List<int> listEVEN = new List<int>();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Write a number");
                var b = Convert.ToInt32(Console.ReadLine());
                 if (b % 2 == 0)
                 {
                     listEVEN.Add(b);
                 }
                 else
                 {
                     listODD.Add(b);
                 }                  
            }                        
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Odd numbers:  " + String.Join(",", listODD));
            Console.WriteLine("Even numbers:  " + String.Join(",", listEVEN));

            #endregion

            #region N2
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("N2");
            Console.WriteLine("Pick a number");
            var c = Convert.ToInt32(Console.ReadLine());
            List <int> numbs = new List<int>();
            for (int i = 0; i < c; i++)            
            {
                Console.WriteLine("Write a number");
                var b = Convert.ToInt32(Console.ReadLine());
                numbs.Add(b);            
            }
            var result = from s in numbs
                         group s by s into y
                         select y;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            foreach (var ricxvi in result)
            {
                Console.WriteLine("Number "+ricxvi.Key+" is mentioned " +
                    +ricxvi.Count()+ " times = sum --> "+ricxvi.Sum());

            }





            #endregion

            #region N3
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("N3");
            List<int> myList = new List<int>() { 20,10,15,17,33, 42,
                56, 13, 19, 38,44};
            Console.WriteLine("The whole list is:  "+ String.Join(",", myList));
            Console.WriteLine("Pick number of top results between (1-11): ");
            var n =Convert.ToInt32(Console.ReadLine());
            List<int> MaxNumbs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var maximum = myList.Max();
                MaxNumbs.Add(maximum);
                int index =myList.FindIndex( x => x == maximum );
                myList.RemoveAt(index);
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Results of top {n} champions " 
                + String.Join(",", MaxNumbs));
            
            #endregion







        }
    }
}
