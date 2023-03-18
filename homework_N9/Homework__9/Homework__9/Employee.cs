using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string jobPosition;
        public int age { get; set; }
        public int averageHours;
        public string dayHours;
        public string JobPosition
        {
            get { return jobPosition; }
            set { if (value == "manager" || value == "developer"
                    || value == "tester" || value == "other")
                {
                    jobPosition= value;
                } else
                {
                    Console.WriteLine("try again, something is wrong");
                }            
            }

        }

        public int AverageHours(int a, int s, int d, int f, int g, int h, int j)
        {   
            var averHours=(a+s+d+f+g+h+j)/7;
            return averHours;
        }

        public string DayHours(int q, int w, int e, int r, int t, int y, int u)
        {   
            List <int> eachDayHours = new List <int>();
            eachDayHours.Add(q);
            eachDayHours.Add(w);
            eachDayHours.Add(e);
            eachDayHours.Add(r);
            eachDayHours.Add(t);
            eachDayHours.Add(y);
            eachDayHours.Add(u);
            return "";          
            
        }
    }

 }
