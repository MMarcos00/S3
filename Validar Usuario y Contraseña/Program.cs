//Validar Usuario y Contraseña
string usuario = "Marcos";
string contraseña = "Marcos123";

try
{
    Console.WriteLine("Introduzca su nombre de usuario: ");
    string nombreUsuario = Console.ReadLine();

    Console.WriteLine("Introduzca su contraseña: ");
    string password = Console.ReadLine();

    if (nombreUsuario == usuario && password == contraseña)
    {
        Console.WriteLine("Acceso correcto.");
    }
    else
    {
        Console.WriteLine("Las credenciales no son válidas.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

