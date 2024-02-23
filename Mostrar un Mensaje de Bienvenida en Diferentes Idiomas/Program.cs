// Mostrar un Mensaje de Bienvenida en Diferentes Idiomas
Console.WriteLine("Introduzca el idioma de su preferencia (español, inglés, francés): ");
string idioma = Console.ReadLine().ToLower();

string mensajeBienvenida;

switch (idioma)
{
    case "español":
        mensajeBienvenida = "¡Bienvenido!";
        break;
    case "inglés":
        mensajeBienvenida = "Welcome!";
        break;
    case "francés":
        mensajeBienvenida = "Bienvenue!";
        break;
    default:
        Console.WriteLine(" El idioma introducido no es válido.");
        return;
}

Console.WriteLine(mensajeBienvenida);

