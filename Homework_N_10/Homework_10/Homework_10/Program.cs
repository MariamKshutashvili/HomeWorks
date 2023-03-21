using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region N1
            
            Console.WriteLine("N1 \nabstract class and the properties");
            var worker = new FileEmployee();
            worker.fileMaxSize = 130;
            Console.WriteLine($"Max size of file is {worker.fileMaxSize}");
            worker.FileExpansion = 80;
            Console.WriteLine($"File is expanded by  {worker.FileExpansion} \n" +
                $"\nmethods:");
            worker.Read();
            worker.Write();
            worker.Edit();
            worker.Delete();
            

            #endregion

            #region N2

            Console.WriteLine("\nN2 ");
            var bank = new Bank();
            bank.CheckUserHistory();

            string result = new String('~', 35);
            Console.WriteLine(result);
            var micro = new MicroFinance();
            micro.CheckUserHistory();
            #endregion

        }

    }
    public interface IFinanceOperations
    {
        void CalculateLoanPercent(int month, double AmountPerMonth);
        void CheckUserHistory();
    }


}
