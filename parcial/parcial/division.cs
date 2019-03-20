using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class division
    {
        public void div()
        {
            int num1;
            int num2;

            Console.WriteLine("INGRESE PRIMER NUMERO");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE PRIMER NUMERO");
            num2 = int.Parse(Console.ReadLine());

            
            if (num2 != 0)
            {
          
                Console.WriteLine("el resultado de la division es" + (num1 / num2));
            }
            else if (num2 == 0)
            {
                Console.WriteLine("erroooor. no se puede dividir entre cero");

            }
        }
    }
}
