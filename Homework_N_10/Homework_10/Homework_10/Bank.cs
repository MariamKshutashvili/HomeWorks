using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework_10.Program;

namespace Homework_10
{
    public class Bank : IFinanceOperations
    {
        public void CalculateLoanPercent(int month, double AmountPerMonth)
        {


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            var amountPayed = Math.Round(month * AmountPerMonth * 0.05,1);
            Console.WriteLine($"Number of months is : {month} \n" +
                $"Monthly payment is : {AmountPerMonth} \n" +
                $"Total payed loan percent is: {amountPayed}");
            Console.ResetColor();
        }

        public void CheckUserHistory()
        {
            Console.WriteLine("The Bank history");
            Random aba = new Random();
            var a = aba.Next(0, 2);
            var truefalse = Convert.ToBoolean(a);
            Console.WriteLine("Your account history is "+truefalse);
            if (truefalse == true)
            {
                Random monthn = new Random();
                var monthN = monthn.Next(0, 13);//random period of time
                                                
                Random monthlypayment = new Random();
                var monthlyPayment = monthlypayment.Next(1000, 2000); //random amount of monthly payment

                CalculateLoanPercent(monthN, monthlyPayment);

            } else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You don't have a hitory in our bank.\n Please register");
                Console.ResetColor();
            }

        }
    }
}
