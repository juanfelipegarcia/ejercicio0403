using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio0403
{
    class Persona
    {
        private string ojos;
        private string color;
        private double altura;

        public Persona()
        {
            this.ojos = "verde";
            this.color = "negro";
            this.altura = 1.80;

        }
        public Persona(string ojos, string color, double altura)
        {
            this.ojos = ojos;
            this.color = color;
            this.altura = altura;
        }

        public string obtenerPersona()
        {
            return "el color de los ojos es: " + this.ojos + "  el color de la piel es: " + this.color + " la altura es: " + this.altura;
        } 
        public string obtenerPersona (string ojos, string color, double altura)
        {
            return "el color de los ojos es: " + this.ojos + "  el color de la piel es: " + this.color + " la altura es: " + this.altura;
        }
    }
}
