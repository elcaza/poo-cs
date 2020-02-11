using System;
using System.Collections.Generic;
using System.Text;

namespace _07NumeroComplejo
{
    /*
     * 7. Se debe diseñar una clase NumeroComplejo, que va a tener como atributos parteReal y parteImaginaria, se debe denir un método imprimir que va a imprimir el número complejo con formato. Se debe denir un método para la suma de dos objetos de la clase NumeroComplejo que retorne un nuevo número complejo que sea la suma de los otros dos. A continuación se debe crear dos números complejos y probar sus métodos. 
         */
    class NumeroComplejo
    {
        public int ParteReal;
        public int ParteImaginaria;
        public NumeroComplejo(int ParteReal, int ParteImaginaria)
        {
            this.ParteReal = ParteReal;
            this.ParteImaginaria = ParteImaginaria;
        }

        public void imprimir()
        {
            if (ParteImaginaria > 0)
                Console.WriteLine("{0}+{1}i", ParteReal, ParteImaginaria);
            else if (ParteImaginaria == 0)
                Console.WriteLine("{0}", ParteReal);
            else
                Console.WriteLine("{0}{1}i", ParteReal, ParteImaginaria);
        }

        public NumeroComplejo sumar(NumeroComplejo n1)
        {
            NumeroComplejo ns = new NumeroComplejo(ParteReal + n1.ParteReal, ParteImaginaria + n1.ParteImaginaria);
            return ns;
        }
    }
}
