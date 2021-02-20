using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            double total;

            Console.Write("Ingrese el total de su compra: ");
            int compra = Convert.ToInt32(Console.ReadLine());
            if((compra>300))
            {
                total = compra - (compra * 0.2);
                Console.Write("Su total es de: " + total);
            }
            else
            {
                total = compra;
                Console.Write("Su total es de: " + total);
            }

            
        }
    }
}
