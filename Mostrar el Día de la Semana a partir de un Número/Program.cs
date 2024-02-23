//Mostrar el Día de la Semana a partir de un Número
Console.WriteLine("Introduzca un número del 1 al 7");
int numeroDia = int.Parse(Console.ReadLine());

string diaSemana;

switch (numeroDia)
{
    case 1:
        diaSemana = "Lunes";
        break;
    case 2:
        diaSemana = "Martes";
        break;
    case 3:
        diaSemana = "Miércoles";
        break;
    case 4:
        diaSemana = "Jueves";
        break;
    case 5:
        diaSemana = "Viernes";
        break;
    case 6:
        diaSemana = "Sábado";
        break;
    case 7:
        diaSemana = "Domingo";
        break;
    default:
        Console.WriteLine("El número introducido no es válido.");
        return;
}

Console.WriteLine("El día de la semana es: " + diaSemana);

