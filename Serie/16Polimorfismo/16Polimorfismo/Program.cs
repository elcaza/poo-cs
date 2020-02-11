using System;

namespace _16Polimorfismo
{
    class Program
    {
        /*
         * Se usa el polimorfismo al tener multiples formas de pasteles
             */
        static void Main(string[] args)
        {
            Pasteles p1 = new Pasteles("Pastel de chocolate", 200, 200);
            Pasteles p2 = new Pasteles("Pastel de chocolate con fruta y dedicatoria", 200, 200, true, false);
            Pasteles p3 = new Pasteles("Pastel de chocolate con dedicatoria", 200, 200, false, true);

            p1.HazPastel();
            p2.HazPastel();
            p3.HazPastel();

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
