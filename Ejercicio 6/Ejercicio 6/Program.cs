using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número para comprobar si es primo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (EsPrimo(num))
            {
            }
            else
            {
            }
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    Console.Write("El número no es primo");
                    return false;
                }
            }
            Console.Write("El número es primo");
            return true;
        }
    }
}
