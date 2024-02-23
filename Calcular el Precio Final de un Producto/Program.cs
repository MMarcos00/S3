// Calcular el Precio Final de un Producto
try
{
    Console.WriteLine("Introduzca el precio original del producto: ");
    double precioOriginal = double.Parse(Console.ReadLine());

    double descuento = precioOriginal > 100 ? 0.1 : 0;
    double precioFinal = precioOriginal - (precioOriginal * descuento);

    Console.WriteLine("El precio final del producto es: " + precioFinal);
}
catch (FormatException ex)
{
    Console.WriteLine("Error: El valor introducido no es un número válido.");
}

