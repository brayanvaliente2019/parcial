using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    public class nombresAlumnos
    {
        public void nombres() {
            
            string nombre;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("INGRESE NOMBRE DE ALUMNOS ");
                nombre = (Console.ReadLine());

                Console.WriteLine( "alumno : "+i + " nombre " + nombre );
            }
            
        }
    }
}
