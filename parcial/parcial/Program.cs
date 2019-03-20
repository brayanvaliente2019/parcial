using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("ingrese 1 para multiplicar");
            Console.WriteLine( "ingrese 2 para dividir" );
            Console.WriteLine( "ingrese 3 para ingresar nombre de alumnos" );
            Console.WriteLine("ingrese 4 para ingresar edades de alumnos ");
            int a=0;
            a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    multiplicaciones obj1 = new multiplicaciones();
                    obj1.multi();
                    break;
                case 2:
                    division obj2 = new division();
                    obj2.div();
                    break;
                case 3:
                    nombresAlumnos obj3 = new nombresAlumnos();
                    obj3.nombres();
                    break;
                case 4:
                    edadesAlumnos obj4 = new edadesAlumnos();
                    obj4.edades();
                    break;
                default:
                    Console.WriteLine("EROOOOOOOOOOOOOOOOOR solo tiene q ser numeros de 1 al 4");
                    break;
               
            }
            Console.WriteLine("--------------------------------------------------------");
            
            Console.ReadKey();
        }
       
    }
}
