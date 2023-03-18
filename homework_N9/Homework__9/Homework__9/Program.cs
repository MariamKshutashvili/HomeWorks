using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Homework__9
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            #region N1
            Console.WriteLine("is it local, write true or false");
            var a =Convert.ToBoolean(Console.ReadLine());
            Company facebook = new Company();
            facebook.IsLocal = a;
           

            Console.WriteLine("which one is the employee: \n " +
                " manager, developer, tester, other ");
            var profesia= Console.ReadLine();
            Employee newEmployee = new Employee();
            newEmployee.jobPosition = profesia;
            Console.WriteLine(newEmployee.jobPosition);

            
            List<string> weekDays = new List<string>()
            { "monday",
            "tuesday",
            "wednesday",
            "thursday",
            "friday",
            "saturday",
            "sunday"
             };
            new string('-', 50);
            List<int> wH = new List<int>();
            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"How many hours did employee work on {weekDays[i]}");
                var wokrHours = Convert.ToInt32(Console.ReadLine());
                wH.Add(wokrHours);
            }
           
            
            newEmployee.DayHours(wH[0], wH[1], wH[2], wH[3],
                wH[4], wH[5], wH[6]);
           Console.WriteLine("average working hours "+newEmployee.AverageHours(wH[0], wH[1], wH[2], wH[3],
                wH[4], wH[5], wH[6]));
            Console.WriteLine("all working hours"+wH.Sum());
            
            Dictionary<string, int> numbProf = new Dictionary<string, int>()
            {
                { "manager" ,40},
                { "developer",30 },
                { "tester", 20 },
                { "other",10 }
            };

            List<int> salary = new List<int>();
            
            for (int i = 0; i < 5; i++)
            {
                if (wH[i] <= 8)
                { salary.Add(wH[i] * numbProf[profesia]); }
                else
                { salary.Add(8* numbProf[profesia] + (wH[i] - 8) * 5); }
            }

            for (int i = 5; i < 7; i++)
            {
                if (wH[i] <= 8)
                { salary.Add(wH[i] * numbProf[profesia]*2); }
                else
                {
                    salary.Add(8* numbProf[profesia] * 2 + (wH[i] - 8) * numbProf[profesia]);
                }
            }
            var salaryfinal=0;
            if (wH.Sum()> 50)
            {
                salaryfinal = salary.Sum() * (int)1.2;
            }
            Console.WriteLine("final salary is  "+salaryfinal);
 
            Console.WriteLine("From the total paid salary, to state taxes goes -->  "
                + facebook.AmountTax(salaryfinal));

            #endregion
           
            #region N2
            Console.WriteLine("hello, choose a favourite subject. \n " +
                "just pick a number 1, 2, 3");

            var subj= Console.ReadLine();
            Student student1 = new Student();
            student1.RandomSubject(subj);

            Console.WriteLine("thanks \n  Now what is your name ");
            student1.Name=Console.ReadLine();
            Console.WriteLine(" Now what is your last name  ");
            student1.lName = Console.ReadLine();
            Console.WriteLine(" Now what is your age ");
            student1.ageofstudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" What year did you get accepted to university? ");
           var left=  student1.YearOfAcceptance( Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"You have left {left}  year(s) at Uni");

            Teacher teacher1 = new Teacher();
            Console.WriteLine($"what is name of the teacher?");
            teacher1.teachName = Console.ReadLine();
            Console.WriteLine("Is teacher certified? write true or false");
            teacher1.IsCertified=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("in this case, you should know:   "+
                teacher1.Test(student1.RandomSubject(subj)));

            #endregion





        }

    }
}
