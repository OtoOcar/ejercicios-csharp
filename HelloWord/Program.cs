namespace HelloWord
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string BirthdayInput;
            Console.WriteLine("¡Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/aaaa: ");
            BirthdayInput = Console.ReadLine();
            bool isValidDate = DateOnly.TryParse(BirthdayInput, out dateConverted);
            if (!isValidDate) Console.WriteLine("La fecha ingresada no es válida. Por favor, inténtalo de nuevo.");
            var person = new Person
            {
                name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre es: {person.name}");
            Console.WriteLine($"Tu fecha de nacimiento es: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age} años");


            Console.WriteLine();
        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public DateOnly Birthday { get; set; }

    }
}