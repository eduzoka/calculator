using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReadResult
    {
        public string Read() //função ou método
        {   
            return Console.ReadLine(); //função do que tem que ser feito (ação)
 
        }

        public decimal ConvertFromString(string receba) 
        { 
            decimal.TryParse(receba, out decimal result);
            return result;
        }
    }
}
