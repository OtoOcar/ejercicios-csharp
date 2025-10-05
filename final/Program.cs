using System;
using itm.charp.basic.Challenges;

namespace itm.charp.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"\r\nHola, {nombre}! \r\nPor favor, elige una opción del siguiente menú:\r\n");
            Menu.MostrarMenu();

            while (true)
            {
                Console.WriteLine("\r\nOpción: ");
                string opcion = Console.ReadLine().ToLower();

                if (opcion == "q" || opcion == "exit")
                    break;

                if (int.TryParse(opcion, out int numeroOpcion) && numeroOpcion >= 1 && numeroOpcion <= 15)
                {
                    switch (numeroOpcion)
                    {
                        case 1: Challenge1.Run(); break;
                        case 2: Challenge2.Run(); break;
                        case 3: Challenge3.Run(); break;
                        case 4: Challenge4.Run(); break;
                        case 5: Challenge5.Run(); break;
                        case 6: Challenge6.Run(); break;
                        case 7: Challenge7.Run(); break;
                        case 8: Challenge8.Run(); break;
                        case 9: Challenge9.Run(); break;
                        case 10: Challenge10.Run(); break;
                        case 11: Challenge11.Run(); break;
                        case 12: Challenge12.Run(); break;
                        case 13: Challenge13.Run(); break;
                        case 14: Challenge14.Run(); break;
                        case 15: Challenge15.Run(); break;
                        default:
                            Console.WriteLine("\nPresione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\nPor favor, elige una opción del siguiente menú:\n");
                            Menu.MostrarMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\r\nOpción no válida. Por favor, elige una opción del menú o 'q' para salir.\r\n");
                    Console.Clear();
                    Console.WriteLine("\nPor favor, elige una opción del siguiente menú:\n");
                    Menu.MostrarMenu();
                }

                Console.WriteLine("\nPresione una tecla para volver al menú...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\nPor favor, elige una opción del siguiente menú:\n");
                Menu.MostrarMenu();
            }

            Console.WriteLine("Gracias por usar el programa. ¡Adiós!");
        }
    }
}
