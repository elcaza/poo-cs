using System;
using System.Collections.Generic;
using System.Text;

namespace _06CuentaBancaria
{
    /**
    * Se debe diseñar una clase CuentaBancaria que va a tener los métodos mostrarInformación, depósito y retiro, como atributos, cada objeto va a tener un saldo y un nombre. El método mostrar información va a imprimir el nombre de la cuenta y el saldo, el método depósito va a agregar una cantidad al saldo de la cuenta y va a mostrar información. El método retiro va a retirar dinero de la cuenta, pero antes tendrá que comprobar que se cuente con el dinero suciente, terminando el retiro va a mostrar información. Cada vez que se cree un objeto, va a mostrar información de la cuenta. Se debe crear dos objetos y llamar sus métodos para probarlos. 
    */
    class CuentaBancaria
    {
        private string nombre;
        private double saldo;

        public CuentaBancaria(string Nombre, double Saldo)
        {
            nombre = Nombre;
            saldo = Saldo;
            Console.WriteLine("La cuenta {0} ha sido creada con exito. Saldo: {1}", nombre, saldo);
        }

        public string mostarInformacion()
        {
            return string.Format("Cuenta: {0}\nSaldo: {1}", nombre, saldo);
        }

        public void depositar(double cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("Debe ingresar una cantidad positiva");
            }
            else
            {
                double SaldoAnterior = saldo;
                saldo += cantidad;
                Console.WriteLine("\n");
                Console.WriteLine("Cuenta: {0} \nSaldo incial: ${1}\nLa cantidad depositada: ${2} \nSaldo actual: ${3}", nombre, SaldoAnterior, cantidad, saldo);
            }
        }

        public void retirar(double retiro)
        {
            if (retiro > saldo)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Cuenta: {0} \nSaldo Insuficiente", nombre);
            }
            else
            {
                double SaldoAnterior = saldo;
                saldo -= retiro;
                Console.WriteLine("\n");
                Console.WriteLine("Cuenta: {0} \nSaldo incial: ${1}\nLa cantidad retirada: ${2} \nSaldo actual: ${3}", nombre, SaldoAnterior, retiro, saldo);
            }
        }
    }
}
