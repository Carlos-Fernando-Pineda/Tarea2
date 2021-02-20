using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main()
        {
            int total;
            int extra;

            Console.Write("Ingrese sus horas trabajadas esta semana: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            if((horas>40))
            {
                extra = horas - 40;
                total = (40 * 16) + (extra * 20);
                Console.Write("El total ganado de esta semana es de: " + total);
            }
            else
            {
                total = horas * 16;
                Console.Write("El total ganado de esta semana es de: " + total);
            }
            
            
        }
    }
}
