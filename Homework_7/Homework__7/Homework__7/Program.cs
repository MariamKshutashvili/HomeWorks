using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace Homework__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region N1

            Console.WriteLine("N1 \n Write the radius for a circle: ");
            var c = Convert.ToInt32(Console.ReadLine());
            var a = 2 * c;
            var s1 = a * a;
            var s2 = a * a / 2;
            var s = s1 - s2;
            Console.WriteLine($"The difference between the areas " +
                $"of the large and small square is: {s}");
            #endregion


            #region N2
            Console.WriteLine("N2 \n write a sequence of numbers or letters!");
            var seq = Convert.ToString(Console.ReadLine());
            List<int> list = new List<int>();            
            foreach (var xo in seq) {
                list.Add(xo);               
            
            }
            var size = list.Count;
            var box = 0;
            for (int i = 0; i< size; i++)
            {
                if (list[i] == list[0])
                {
                    box++;
                }
            }
            if (box == size)
            {
                Console.WriteLine("Yes!!!! congrats");
            }
            else  {
                Console.WriteLine("No, try again, maybe " +
                    "next time you will win");
             } 
                           
                #endregion
               

            #region N3            
                Console.WriteLine("N3");
            Console.WriteLine("Write the number of wins:");
            var w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of draws:");
            var d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of losses:");
            var L = Convert.ToInt32(Console.ReadLine());
            
            var sumWin = w * 3;
            var sumDraw = d * 1;
            var sumLoss = L * 0;
            var total = sumDraw + sumWin + sumLoss;
            Console.WriteLine("Your team has the total score of: " +total);
            #endregion


            #region N4
            Console.WriteLine("N4 \n We will ask you how many " +
                "hours did the worker work every day");
            List<string> Weekdays = new List<string>() {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
               "Saturday",
                "Sunday" };

            List<int> Working_hours = new List<int>();
            for (int i = 0; i < 7; i++) {
                Console.WriteLine($"How many hours did the worker work on {Weekdays[i]}?");
                var Wh = Convert.ToInt32(Console.ReadLine());
                Working_hours.Add( Wh );
            }
            Console.WriteLine("Working hours were: " +String.Join(" , ", Working_hours));
            List<int> salary = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                if (Working_hours[i] <= 8)
                { salary.Add(Working_hours[i] * 10); }
                else
                {salary.Add(80 + (Working_hours[i] - 8) * 5);  }    }

            for (int i = 5; i < 7; i++)
            {   if (Working_hours[i] <= 8)
                {  salary.Add(Working_hours[i] * 20);        }
                else       {
                    salary.Add(160 + (Working_hours[i] - 8) * 10);  } }
            
            Console.WriteLine("the weekly salary is:  "+ salary.Sum());

            #endregion

            
            #region N5
            Console.WriteLine("N5 \n How many days did you workout?");
            var days = Convert.ToInt32(Console.ReadLine());
            List<int> progress = new List<int>();
            
            var score = 0;
            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"What was the result of day {i + 1}");
                var outcome = Convert.ToInt32(Console.ReadLine());
                progress.Add(outcome);
            }
            int min = progress[0];
            int max = progress[0];
            for (int i = 1; i < days; i++)
            {
                if (max < progress[i])
                {
                    max = progress[i];
                    score++;
                }                      
            }
            Console.WriteLine("improvement days: --- " + score + "\n counting only " +
                "days with better results than the day before.");
            #endregion
            

            #region N6
            Console.WriteLine("N6 \n Write the length of the word: ");
            var lengTh = Convert.ToInt32(Console.ReadLine());
            List<string> randomWords = new List<string>()
            { "i",
            "me",
            "baby",
            "hello",
            "yes",
            "desktop",
            "anaconda",
            "Consanguineous",
            "interfere",
            "determiners",
                        };

            Dictionary<int, string> wordWithN = new Dictionary<int, string>();
            for (int i = 0; i < randomWords.Count; i++)
            {
                var h = randomWords[i].Length;
                wordWithN.Add(h, randomWords[i]);
            }

            if (wordWithN.ContainsKey(lengTh))
                {
                Console.WriteLine(wordWithN[lengTh]); }
            else { Console.WriteLine("No elements found"); }
            
            #endregion




        }
    }
   
}
