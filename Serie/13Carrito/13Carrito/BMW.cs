using System;
using System.Collections.Generic;
using System.Text;

namespace _13Carrito
{
    class BMW : Carro
    {
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public BMW(double peso, double altura) : base(peso, altura) { }
        public override string ToString()
        {
            return string.Format("El modelo {0}: pesa {1}kgs y mide {2}mts de altura", modelo, Peso, Altura);
        }
    }
}
