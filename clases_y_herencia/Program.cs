//Clases
Console.WriteLine();
Console.WriteLine("Propiedades de un rectángulo:");
Console.WriteLine();

var rect = new Rectangulo();
rect.Base = 10;
rect.Altura = 5;
Console.WriteLine($"Área del rectángulo: {rect.Area()}");
Console.WriteLine($"Perímetro del rectángulo: {rect.Perimetro()}");


Console.WriteLine();
Console.WriteLine("Propiedades de un cuadrado:");
Console.WriteLine();


var cuadrado = new Cuadrado();
cuadrado.Lado = rect.Base;
Console.WriteLine($"Área del cuadrado: {cuadrado.Area()}");
Console.WriteLine($"Perímetro del cuadrado: {cuadrado.Perimetro()}");
Console.WriteLine($"Lado del cuadrado: {cuadrado.Lado}");


//Herencia
class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * (Base + Altura);
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}


/*
var cuadrado = new Cuadrado();
cuadrado.Base = 10;
cuadrado.Altura = 5;
Console.WriteLine($"Área del cuadrado: {cuadrado.Area()}");
Console.WriteLine($"Perímetro del cuadrado: {cuadrado.Perimetro()}");
Console.WriteLine($"Lado del cuadrado: {cuadrado.Lado}");
*/