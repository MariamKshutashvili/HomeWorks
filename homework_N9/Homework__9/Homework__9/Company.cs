using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class Company
    {
        public bool IsLocal;
               

        public int AmountTax(int x)
        {
            if (IsLocal)
            {
                var b  = x * 18 / 100;

                return (int)b;
            }
            else {
                double a = x * 0.05;
                return (int) a; }

        }





    }
}
