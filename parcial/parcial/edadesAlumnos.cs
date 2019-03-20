using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class edadesAlumnos
    {
        public void edades()
        {
            int i=1;
            int edad;
            do
            {
                Console.WriteLine("INGRESE EDAD DE ELUMNOS");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("alumno: " + i + " edad " + edad);
                i = i + 1;
            } while (i<6);
            
        }
    }
}
