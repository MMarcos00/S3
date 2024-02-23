// Convertir un Número de Letra a Número
Console.WriteLine("Introduzca un número del 1 al 5 en letra");
string numeroLetra = Console.ReadLine().ToLower();

int numero;

switch (numeroLetra)
{
    case "uno":
        numero = 1;
        break;
    case "dos":
        numero = 2;
        break;
    case "tres":
        numero = 3;
        break;
    case "cuatro":
        numero = 4;
        break;
    case "cinco":
        numero = 5;
        break;
    default:
        Console.WriteLine("El número introducido no es válido.");
        return;
}

Console.WriteLine("El número en dígito es: " + numero);

