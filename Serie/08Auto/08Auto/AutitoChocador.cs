using System;
using System.Collections.Generic;
using System.Text;

namespace _08Auto
{
    class AutitoChocador
    {
        string marca;
        double precio;
        int serie;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        public AutitoChocador()
        {
            Console.WriteLine("El rasho mcQuin " + "8795412578924" + " $2000000");
        }

        public AutitoChocador(string marca, int serie, double precio)
        {
            this.marca = marca;
            this.serie = serie;
            this.precio = precio;
        }

        public void Encender()
        {
            Console.WriteLine("Brrrm! (Encendido)");
        }

        public void Acelerar()
        {
            Console.WriteLine("Ruuuuun, ruuuuuuuun, RUUUUUN! (Acelerando)");
        }

        public void Apagar()
        {
            Console.WriteLine("Brf! (Apagado)");
        }
    }
}
