using System;
using System.Collections.Generic;
using System.Text;

namespace _09Math
{
    /*
     * 9. Haz una pequeña investigación sobre los métodos que se encuentran en la clase Math y para qué sirven. Crea una clase llamada Cículo y otra con el nombre de la gura geométrica de tu preferencia. Cada clase deberá tener sus respectivos atributos y métodos de tal manera que ocupes mínimo tres métodos de la clase Math.
     */
    class Geometria
    {
    }

    class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            try
            {
                Radio = Math.Abs(radio);
            }
            catch
            {
                Console.WriteLine("Ocurrió un error");
            }

        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public void DatosCirculo()
        {
            Console.WriteLine("Radio: {0}\nPerímetro: {1}\nÁrea: {2}", Radio, CalcularPerimetro(), CalcularPerimetro());
        }
    }

}
