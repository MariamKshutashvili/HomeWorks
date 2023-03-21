using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_10.Program;

namespace Homework_10
{
    public class MicroFinance : IFinanceOperations
    {
        public void CalculateLoanPercent(int month, double AmountPerMonth)
        { 
            

            var amountPayed = 0.0;
            var starter = AmountPerMonth;
            for (int i = 0; i < month; i++)
            {
                amountPayed = amountPayed + (starter - amountPayed - 4.0) * 0.1;
            }
            var simple = 0.0;
            var simpleAmount = Math.Round(AmountPerMonth * month * 0.1 + 4 * month,1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Number of months is : {month} \n" +
                $"Monthly payment is : {AmountPerMonth} \n");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The Simple interest is : " + simpleAmount);
            Console.WriteLine("the Compound interest is : " + Math.Round(amountPayed,1));

            Console.ResetColor();

        }

        public void CheckUserHistory()
        {
            Console.WriteLine("The Micro Finance history");

            bool history =true;
            Random monthn = new Random();
            var monthN = monthn.Next(0, 13);//random period of time

            Random monthlypayment = new Random();
            var monthlyPayment = monthlypayment.Next(1000, 2000); //random amount of monthly payment

            CalculateLoanPercent(monthN, monthlyPayment);

         }
    }
}
