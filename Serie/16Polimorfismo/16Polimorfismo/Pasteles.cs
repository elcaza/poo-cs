using System;
using System.Collections.Generic;
using System.Text;

namespace _16Polimorfismo
{
    public class Pasteles 
    {
        private string nombre;
        private double carbohidratos;
        private double calorias;
        private bool fruta;
        private bool dedicatoria;
        public Pasteles(string nombre, double carbohidratos, double calorias)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.calorias = calorias;
        }

        public Pasteles(string nombre, double carbohidratos, double calorias, bool fruta, bool dedicatoria)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.calorias = calorias;
            this.fruta = fruta;
            this.dedicatoria = dedicatoria;
        }

        public void HazPastel()
        {
            Console.WriteLine("\nHola, soy un pastel de {0} con {1} carbohidratos y {2} calorias.", this.nombre, this.carbohidratos, this.calorias);

            if (this.fruta)
            {
                Console.WriteLine("\tLlevo fruta");
            }

            if (this.fruta)
            {
                Console.WriteLine("\tLlevo dedicatoria");
            }


        }
    }
}
