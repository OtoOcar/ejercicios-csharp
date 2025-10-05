using System;
using itm.charp.basic.Validar;


namespace itm.charp.basic.Challenges
{
    // 1. Determinar si un número es positivo, negativo o cero.
    public static class Challenge1
    {
        public static void Run()
        {
            int num = Validaciones.LeerEntero("Ingrese un número:");
            if (num > 0) Console.WriteLine("El número es positivo.");
            else if (num < 0) Console.WriteLine("El número es negativo.");
            else Console.WriteLine("El número es cero.");
        }
    }

    // 2. Operaciones básicas entre dos números.
    public static class Challenge2
    {
        public static void Run()
        {
            int num1 = Validaciones.LeerEntero("Ingrese el primer número:");
            int num2 = Validaciones.LeerEntero("Ingrese el segundo número:");

            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1 * num2}");
            if (num2 != 0)
                Console.WriteLine($"División: {(double)num1 / num2}");
            else
                Console.WriteLine("División: No se puede dividir por cero.");
        }
    }

    // 3. Calcular área y perímetro de un rectángulo.
    public static class Challenge3
    {
        public static void Run()
        {
            int largo = Validaciones.LeerEntero("Ingrese el largo del rectángulo:");
            int ancho = Validaciones.LeerEntero("Ingrese el ancho del rectángulo:");

            int area = largo * ancho;
            int perimetro = 2 * (largo + ancho);

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    }

    // 4. Determinar si un año es bisiesto.
    public static class Challenge4
    {
        public static void Run()
        {
            int year = Validaciones.LeerEntero("Ingrese un año:");
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine($"{year} es un año bisiesto.");
            else
                Console.WriteLine($"{year} no es un año bisiesto.");
        }
    }

    // 5. Encontrar el número mayor entre tres números.
    public static class Challenge5
    {
        public static void Run()
        {
            int num1 = Validaciones.LeerEntero("Ingrese el primer número:");
            int num2 = Validaciones.LeerEntero("Ingrese el segundo número:");
            int num3 = Validaciones.LeerEntero("Ingrese el tercer número:");

            int mayor = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }

    // 6. Calcular el factorial de un número.
    public static class Challenge6
    {
        public static void Run()
        {
            int num = Validaciones.LeerEntero("Ingrese un número para calcular su factorial:");
            if (num < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
                return;
            }

            long factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");
        }
    }

    // 7. Realizar una división.
    public static class Challenge7
    {
        public static void Run()
        {
            int num1 = Validaciones.LeerEntero("Ingrese el dividendo:");
            int num2 = Validaciones.LeerEntero("Ingrese el divisor:");

            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return;
            }

            double resultado = (double)num1 / num2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
    }

    // 8. Sumar números impares entre 1 y 100.
    public static class Challenge8
    {
        public static void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números impares entre 1 y 100 es: {suma}");
        }
    }

    // 9. Operaciones con fracciones.
    public static class Challenge9
    {
        public static void Run()
        {
            int num1 = Validaciones.LeerEntero("Ingrese el numerador de la primera fracción:");
            int den1 = Validaciones.LeerDenominador("Ingrese el denominador de la primera fracción:");

            int num2 = Validaciones.LeerEntero("Ingrese el numerador de la segunda fracción:");
            int den2 = Validaciones.LeerDenominador("Ingrese el denominador de la segunda fracción:");

            try
            {
                // Suma
                int sumaNum = num1 * den2 + num2 * den1;
                int sumaDen = den1 * den2;
                Console.WriteLine($"Suma: {sumaNum}/{sumaDen}");

                // Resta
                int restaNum = num1 * den2 - num2 * den1;
                int restaDen = den1 * den2;
                Console.WriteLine($"Resta: {restaNum}/{restaDen}");

                // Multiplicación
                int multNum = num1 * num2;
                int multDen = den1 * den2;
                Console.WriteLine($"Multiplicación: {multNum}/{multDen}");

                // División
                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir por una fracción con numerador cero.");
                    return;
                }

                int divNum = num1 * den2;
                int divDen = den1 * num2;
                Console.WriteLine($"División: {divNum}/{divDen}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
    }

    // 10. Determinar si un número es impar.
    public static class Challenge10
    {
        public static void Run()
        {
            int num = Validaciones.LeerEntero("Ingrese un número:");
            if (num % 2 != 0)
                Console.WriteLine("El número es impar.");
            else
                Console.WriteLine("El número no es impar.");
        }
    }

    // 11. Ingresar 5 números válidos.
    public static class Challenge11
    {
        public static void Run()
        {
            int[] numeros = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = Validaciones.LeerEntero($"Ingrese el número {i + 1}:");
            }

            Console.WriteLine("Los números ingresados son:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }

    // 12. Animales hablando.
    public static class Challenge12
    {
        public static void Run()
        {
            Console.WriteLine("El perro dice: ¡Guau!");
            Console.WriteLine("El gato dice: ¡Miau!");
            Console.WriteLine("La vaca dice: ¡Muu!");
            Console.WriteLine("El pato dice: ¡Cuac!");
        }
    }

    // 13. Categorizar por edad.
    public static class Challenge13
    {
        public static void Run()
        {
            int edad = Validaciones.LeerEntero("Ingrese su edad:");

            if (edad < 0)
                Console.WriteLine("Edad inválida.");
            else if (edad <= 12)
                Console.WriteLine("Categoría: Niño.");
            else if (edad <= 19)
                Console.WriteLine("Categoría: Adolescente.");
            else if (edad <= 59)
                Console.WriteLine("Categoría: Adulto.");
            else
                Console.WriteLine("Categoría: Adulto mayor.");
        }
    }

    // 14. Agregar contactos a una agenda.
    public static class Challenge14
    {
        public static void Run()
        {
            var agenda = new System.Collections.Generic.List<(string Nombre, string Telefono)>();

            for (int i = 0; i < 3; i++) // Limitado a 3 contactos para simplicidad
            {
                Console.Write("Ingrese el nombre del contacto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el teléfono del contacto: ");
                string telefono = Console.ReadLine();

                agenda.Add((nombre, telefono));
            }

            Console.WriteLine("\nContactos en la agenda:");
            foreach (var contacto in agenda)
            {
                Console.WriteLine($"Nombre: {contacto.Nombre}, Teléfono: {contacto.Telefono}");
            }
        }
    }

    // 15. Operaciones bancarias.
    public static class Challenge15
    {
        public static void Run()
        {
            double saldo = 0.0;

            while (true)
            {
                Console.WriteLine("\nSeleccione una operación:");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("q. Salir");

                string opcion = Console.ReadLine().ToLower();
                if (opcion == "q")
                    break;

                switch (opcion)
                {
                    case "1":
                        double deposito = Validaciones.LeerEntero("Ingrese el monto a depositar:");
                        if (deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido.");
                        }
                        break;

                    case "2":
                        double retiro = Validaciones.LeerEntero("Ingrese el monto a retirar:");
                        if (retiro > 0 && retiro <= saldo)
                        {
                            saldo -= retiro;
                            Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido o saldo insuficiente.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Saldo actual: {saldo}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}

