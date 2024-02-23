//Evaluar la Calificación de un Examen:
try
{
    Console.WriteLine("Introduzca la calificación del examen: ");
    int calificacion = int.Parse(Console.ReadLine());

    string mensaje;

    if (calificacion >= 0 && calificacion <= 100)
    {
        switch (calificacion)
        {
            case 90:
            case 91:
            case 92:
            case 93:
            case 94:
            case 95:
            case 96:
            case 97:
            case 98:
            case 99:
            case 100:
                mensaje = "¡Sobresaliente! Excelente desempeño.";
                break;
            case 80:
            case 81:
            case 82:
            case 83:
            case 84:
            case 85:
            case 86:
            case 87:
            case 88:
            case 89:
                mensaje = "Notable. Buen desempeño.";
                break;
            case 70:
            case 71:
            case 72:
            case 73:
            case 74:
            case 75:
            case 76:
            case 77:
            case 78:
            case 79:
                mensaje = "Aprobatoria. Debes mejorar tu rendimiento.";
                break;
            case 60:
            case 61:
            case 62:
            case 63:
            case 64:
            case 65:
            case 66:
            case 67:
            case 68:
            case 69:
                mensaje = "No aprobatoria. Estudia más para la próxima vez.";
                break;
            default:
                mensaje = " La calificación no es válida.";
                break;
        }

        Console.WriteLine(mensaje);
    }
    else
    {
        Console.WriteLine("La calificación debe estar entre 0 y 100.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine(" El valor introducido no es un número válido.");
}
