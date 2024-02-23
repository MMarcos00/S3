// Calcular el Importe a Pagar por un Servicio
Console.WriteLine("Introduzca el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica): ");
string tipoServicio = Console.ReadLine().ToLower();

double importe;

switch (tipoServicio)
{
    case "lavado de auto":
        importe = 20;
        break;
    case "cambio de aceite":
        importe = 50;
        break;
    case "revisión mecánica":
        importe = 80;
        break;
    default:
        Console.WriteLine("El tipo de servicio introducido no es válido.");
        return;
}

Console.WriteLine("El importe a pagar es: " + importe + "Q");
