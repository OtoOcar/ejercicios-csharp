// Conditionals
/*
Console.WriteLine("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (numero < 0)
{
    Console.WriteLine("El número es negativo.");
}
else
{
    Console.WriteLine("El número es cero.");
}
*/

// Conditionals

Console.WriteLine("Ingrese el primer número: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: "); 
double num2 = double.Parse(Console.ReadLine());
const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {(num1 + num2)}, Resta: {(num1 - num2)}, Multiplicación: {(num1 * num2)}, División: {(num2 != 0 ? (num1 / num2).ToString() : Indeterminado)}");
