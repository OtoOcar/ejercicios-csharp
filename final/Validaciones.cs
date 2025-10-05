using System;

namespace itm.charp.basic.Validar
{
    public static class Validaciones
    {
        // Método para leer y validar un número entero
        public static int LeerEntero(string mensaje)
        {
            int numero;
            bool esValido = false;

            do
            {
                Console.Write(mensaje + " ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.\r\n");
                }

            } while (!esValido);

            return numero;
        }


        // Método auxiliar para validar que el denominador no sea cero
        public static int LeerDenominador(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero != 0)
                        return numero;
                    Console.WriteLine("El denominador no puede ser cero. Intente nuevamente.");
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número entero válido.");
                }
            }
        }
    }
}



