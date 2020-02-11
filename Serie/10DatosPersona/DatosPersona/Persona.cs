using System;
using System.Collections.Generic;
using System.Text;

namespace DatosPersona
{
    class Persona
    {
        DateTime fecha = new DateTime(2020, 2, 10, 00, 00, 00);


        public string Nombre;
        public int yearNac;
        public int Estatura;
        public int Peso;

        public Persona(string nombre, int año, int estatura, int peso)
        {
            this.Nombre = nombre;
            this.yearNac = año;
            this.Estatura = estatura;
            this.Peso = peso;
        }

        public void calcularEdad(int edad)
        {
            int edad_persona = fecha.Year - edad;
            Console.WriteLine("\n{0} tiene {1} años.", Nombre, edad_persona);
        }

        public void cmToft(int estatura)
        {
            double estaturaEnFt = estatura * 0.032808;
            Console.WriteLine("\n{0} mide {1} ft. ({2} cm)", Nombre, estaturaEnFt, estatura);
        }

        public void kgTolb(int peso)
        {
            double pesoEnlb = peso * 2.20462; // Factor de conversión (kg -> lb)
            Console.WriteLine("\n{0} pesa {1} libras. ({2} kg)", Nombre, pesoEnlb, peso);
        }
    }
}
