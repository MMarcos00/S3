//Mostrar un Mensaje de Aprobación o Rechazo de Préstamo
try
{
    Console.WriteLine("Introduzca el monto del préstamo: ");
    double montoPrestamo = double.Parse(Console.ReadLine());

    Console.WriteLine("Introduzca su edad: ");
    int edad = int.Parse(Console.ReadLine());

    bool aprobado = montoPrestamo <= 5000 || edad >= 60;

    if (aprobado)
    {
        Console.WriteLine("Su préstamo ha sido aprobado.");
    }
    else
    {
        Console.WriteLine("Su préstamo no ha sido aprobado.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("El valor introducido no es un número");
}
