using System;
using System.Collections.Generic;
using System.Text;

namespace _16Polimorfismo
{
    public class Comida
    {
        private string nombre;
        private double carbohidratos;
        private double calorias;
        public Comida(string nombre, double carbohidratos, double calorias)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.calorias = calorias;
        }
    }
}
