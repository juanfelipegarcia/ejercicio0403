using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio0403
{
    class Numero
    {
        private int num1;
        private int num2;

        public Numero(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public Numero()
        {
            this.num1 = 5;
            this.num2 = 3;
        }

        public string obtenerNumero()
        {
            return "El  numero 1 es :" + num1 + "  y el numero 2 es  : " + num2;
        }

    }
}
