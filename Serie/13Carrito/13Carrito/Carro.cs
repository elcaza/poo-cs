using System;
using System.Collections.Generic;
using System.Text;

namespace _13Carrito
{
    class Carro
    {
        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        private double peso;
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private bool encendido;
        public bool Encendido
        {
            get { return encendido; }
            set { encendido = false; }
        }
        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("Brrrm! Auto encendido");
        }
        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("Frr! Auto apagado");
        }
        public void Estado()
        {
            if (encendido)
            {
                Console.WriteLine("Encendido :)");
            }
            else
            {
                Console.WriteLine("Apagado :D");
            }
        }
        public override string ToString()
        {
            return string.Format("El peso del auto es de {0}kg y su altura es de {1}mts", peso, altura);
        }
    }
}
