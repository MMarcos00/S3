//Validar Edad para Ingresar a un Club
try
{
    Console.WriteLine("Introduzca su edad: ");
    int edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
        Console.WriteLine("¡Bienvenido al club!");
    }
    else
    {
        Console.WriteLine("Lo sentimos, no puedes ingresar al club. Debes ser mayor de 18 años.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Error: El valor introducido no es un número válido.");
}

