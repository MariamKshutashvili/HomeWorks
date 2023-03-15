using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Homework__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N1 \n Min number: ");
            var a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Max number: ");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power number: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Number(a, b, n);

            Console.WriteLine("N2  \n  Write something and find pairs in it");
            var p = Console.ReadLine();
            Pairs(p);
            Console.WriteLine("N3  \n  Write something to find the same ending with another word");
            var word1 = Console.ReadLine();            
            Console.WriteLine("Write something to find the same ending with another word");
            var word2 = Console.ReadLine();
            Ending(word1, word2);

            Console.WriteLine("N4 \n  write int, string or bool list !!");
            var word3 = Console.ReadLine();
            Console.WriteLine(RandomValues("a", word3));

            Console.WriteLine("N5 \n write a big number !!");
            var rep =Console.ReadLine();
            Repeating(rep);

        }


        static void Number(int a, int b, int n)
        {
            var a1=Math.Ceiling(Math.Pow(a, (double) 1 / n));
            var a2=Convert.ToInt32(a1);            
            var b1= Math.Ceiling(Math.Pow(b, (double)1 / n));
            var b2=Convert.ToInt32(b1);
            List <int> powered = new List <int>();
           for (int i= a2; i < b2; i++)
            {
                var c = Convert.ToInt32(Math.Pow(i, n));               
                powered.Add(c);

            }
            Console.WriteLine ("Count is "+powered.Count);
            Console.WriteLine("The powered list is:  "+String.Join(" , ",powered));
            
            
        }

        static void Pairs(string p)
        {   List <string> strings = new List <string>();

            foreach(var thing in p)
            {
                var thingNew = Convert.ToString(thing);
                strings.Add(thingNew);
            }

            var sia =from s in strings
                        group s by s into y
                        select y;

            foreach (var n in sia)
            {
                var result =Convert.ToInt32( n.Count());
                var es = result / 2;
                if (es > 0)
                {
                    Console.WriteLine(n.Key+n.Key + " times "+es);
                } else { Console.WriteLine(""); }                              
                
            }     




        }

        static void Ending(string x, string y)
        {
            List <string> strings1 = new List <string>();
            List <string> strings2 = new List <string>();

            foreach (var thing in x)
            {   var thingNew = Convert.ToString(thing);   
                strings1.Add(thingNew);
            }

            foreach (var h in y)
            {   var hNew = Convert.ToString(h);
                strings2.Add(hNew);
            }
            var size1 = strings1.Count();
            var size2 = strings2.Count();
            int i = 0;
            List<string> string3 = new List <string>();
            
            while (strings1[size1 - 1-i] == strings2[size2 - 1-i])
            {
                string3.Add(strings1[size1 - 1- i]);
                i++;
                
            }
            string3.Reverse();
            Console.WriteLine(String.Join("", string3));         
                    
            
                      

        }


        public static T RandomValues<T>(string x, T defaultValue)
        {   
            var result = x;
            List <string> stringss = new List <string>();
            foreach (var thing in x)
            {
                if (char.IsDigit(thing)){

                }

                if (char.IsLetter(thing)){

                }

                if (char.IsDigit(thing))
                {

                }
            }

            return defaultValue; 
                    
                    
            //int i4;
            //string i2;
            //bool i3;

            //if (int.TryParse(x, out i))
            //    {
            //    Console.WriteLine("int");
            //}
            //if(bool.TryParse(x, out i3)){
            //    Console.WriteLine("bool");
            //} else
            //{
            //    Console.WriteLine("string");
            //}




            return defaultValue;
            

            if (x.GetType() == typeof(string))
            {
                Console.WriteLine();
            }
            if (typeof(T) == typeof(int) )
            {
                Console.WriteLine();
            }
            if(typeof(T) == typeof(bool))
            {
                Console.WriteLine();    
            }





            }
        
        
        
        static void Repeating(string x){
            List <string> strings = new List <string>();   
            foreach (var thing in x)
            {
                var thing1 = Convert.ToString(thing);
                strings.Add(thing1);           }
            Console.WriteLine(String.Join(" - ",strings));
            }







        







    }
}
