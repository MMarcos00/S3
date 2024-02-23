//Calcular el Área de una Figura Geométrica
try
{
    Console.WriteLine("Introduzca el tipo de figura geométrica (triángulo, cuadrado o círculo): ");
    string tipoFigura = Console.ReadLine().ToLower();

    if (tipoFigura == "triángulo")
    {
        Console.WriteLine("Introduzca la base del triángulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca la altura del triángulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }
    else if (tipoFigura == "cuadrado")
    {
        Console.WriteLine("Introduzca el lado del cuadrado: ");
        double ladoCuadrado = double.Parse(Console.ReadLine());

        double areaCuadrado = ladoCuadrado * ladoCuadrado;
        Console.WriteLine("El área del cuadrado es: " + areaCuadrado);
    }
    else if (tipoFigura == "círculo")
    {
        Console.WriteLine("Introduzca el radio del círculo: ");
        double radioCirculo = double.Parse(Console.ReadLine());

        double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
        Console.WriteLine("El área del círculo es: " + areaCirculo);
    }
    else
    {
        Console.WriteLine("El tipo de figura geométrica no es válido.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("El valor introducido no es un número válido.");
}
