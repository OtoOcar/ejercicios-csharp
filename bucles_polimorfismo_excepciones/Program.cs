// Polimorfismo
/*
var circulo = new Circulo();

circulo.Radio = 5;
var areaCirculo = circulo.CalcularArea();
var perimetroCirculo = circulo.CalcularPerimetro();

Console.WriteLine($"Área del circulo: {areaCirculo}");
Console.WriteLine($"Perímetro del circulo: {perimetroCirculo}");
Console.WriteLine($"Radio Extra: {circulo.Add10()}");
*/

// Bucles
int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}
// Fin Bucles


//Excepciones
try
{
    Console.WriteLine("Número a dividir: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine($"Divisor: ");
    double d = double.Parse(Console.ReadLine());

    if (d == 0)
    {
        throw new DivideByZeroException("No se puede dividir por cero.");
    }

    Console.WriteLine($"Resultado: {n / d}");
}
catch (FormatException ex)
{
    Console.WriteLine("Error de formato: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error de división por cero: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Error general: " + ex.Message);
}
finally
{
    Console.WriteLine("Operación finalizada.");
}
//Fin Excepciones



interface IRadioExtra
{ public double Add10(); }


interface IFigura
{
    public double CalcularArea();
    public double CalcularPerimetro();
}

class Circulo : IFigura, IRadioExtra
{
    public double Radio { get; set; }

    public double CalcularArea() => Math.PI * Radio * Radio;
    public double CalcularPerimetro() => 2 * Math.PI * Radio;
    public double Add10()
    {
        return Radio + 10;
    }
}


