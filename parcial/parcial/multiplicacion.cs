using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class multiplicaciones
    {
        public void multi() {

            int num1; 
            int num2;

            Console.WriteLine("INGRESE PRIMER NUMERO");
            num1=int.Parse(Console.ReadLine());

            if (num1==0){
                Console.WriteLine("el producto de 0 es por cualquier numeri es 0");

            }
	        else if(num1 != 0){
                 Console.WriteLine("INGRESE PRIMER NUMERO");
                 num2=int.Parse(Console.ReadLine());
                
                Console.WriteLine( "el resultado de la multiplcacion es"+(num1*num2) );
            }
           
            

        }
    }
}
