//Determinar si un Número es Par o Impar
try
{
    Console.WriteLine("Introduzca un número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("PAR");
    }
    else
    {
        Console.WriteLine("IMPAR");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("El valor introducido no es un número ");
}

