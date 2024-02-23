//Calcular el Mayor de Tres Números
try
{
    Console.WriteLine("Introduzca el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca el tercer número: ");
    int num3 = int.Parse(Console.ReadLine());

    int mayor = Math.Max(Math.Max(num1, num2), num3);

    Console.WriteLine("El mayor de los tres números es: " + mayor);
}
catch (FormatException ex)
{
    Console.WriteLine("Error: El valor introducido no es un número válido.");
}
