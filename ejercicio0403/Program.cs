using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio0403
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor colorDeLaConsola = ConsoleColor.DarkGreen;
            Console.BackgroundColor = colorDeLaConsola;

            //Numero miNumero = new Numero(3,8);



            //Console.WriteLine(miNumero.obtenerNumero());

            //Persona miNegro = new Persona("amarillos","moreno",1.55);

            Persona miNegro = new Persona("amarillos", "moreno", 1.55, 55);

            //miNegro.this.ojos = "morados";


            //Console.WriteLine(miNegro.ojos = "morados");
            //Console.WriteLine(miNegro.altura);
            //Console.WriteLine(miNegro.color);

            Console.WriteLine(miNegro.obtenerPersona());

            Console.ReadKey();
        }
    }
}
