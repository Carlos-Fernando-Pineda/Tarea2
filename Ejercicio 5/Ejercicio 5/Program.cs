using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Domingo");
            Console.WriteLine("2. Lunes");
            Console.WriteLine("3. Martes");
            Console.WriteLine("4. Miercoles");
            Console.WriteLine("5. Jueves");
            Console.WriteLine("6. Viernes");
            Console.WriteLine("7. Sábado");
            Console.WriteLine("Seleccione un dia de la semana: ");
            int op = Convert.ToInt32(Console.ReadLine()); 
            
            switch (op)
            {
                case 1:
                    Console.WriteLine("Domingo no es un día laboral");
                    break;
                case 2:
                    Console.WriteLine("Lunes es un día laboral");
                    break;
                case 3:
                    Console.WriteLine("Martes es un día laboral");
                    break;
                case 4:
                    Console.WriteLine("Miercoles es un día laboral");
                    break;
                case 5:
                    Console.WriteLine("Jueves es un día laboral");
                    break;
                case 6:
                    Console.WriteLine("Viernes es un día laboral");
                    break;
                case 7:
                    Console.WriteLine("Sábado no es un día laboral");
                    break;
                default:
                    Console.WriteLine("Esta no es una opción, seleccione otra");
                    break;
            }
        }
    }
}
