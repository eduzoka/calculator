using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculadora
    {

        public decimal Somar(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Subtrair(decimal x, decimal y)
        {
            return x - y;
        }

        public decimal Dividir(decimal x, decimal y)
        {
            return x / y;
        }

        public decimal Multiplicar(decimal x, decimal y)
        {
            return x * y;
        }
    }
}
