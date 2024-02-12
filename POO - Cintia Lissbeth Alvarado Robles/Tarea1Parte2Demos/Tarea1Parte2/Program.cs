using System;
using Tarea1Parte2;

class Program
{
    static void Main(string[] args)
    {
        var tienda = new TiendaElectronica("Electronics Store");

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Listar Productos");
            Console.WriteLine("3. Abrir Tienda");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto(tienda);
                    break;
                case "2":
                    tienda.ListarProductos();
                    break;
                case "3":
                    TiendaElectronica.AbrirTienda(tienda.NombreTienda);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarProducto(TiendaElectronica tienda)
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        double precio;
        while (!double.TryParse(Console.ReadLine(), out precio))
        {
            Console.WriteLine("Precio inválido. Intente de nuevo.");
            Console.Write("Ingrese el precio del producto: ");
        }

        Console.Write("Ingrese la marca del producto: ");
        string marca = Console.ReadLine();

        var producto = new ProductoElectronico(nombre, precio, marca);
        tienda.AgregarProducto(producto);

        Console.WriteLine("Producto agregado exitosamente.");
    }
}
