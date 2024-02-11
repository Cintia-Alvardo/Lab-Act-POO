using System;

class Program
{
    static void Main(string[] args)
    {
        LocalReparacion localReparacion = new LocalReparacion();

        while (true)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Agregar vehículo");
            Console.WriteLine("2. Listar todos los vehículos");
            Console.WriteLine("3. Listar vehículos por categoría");
            Console.WriteLine("4. Marcar vehículo como reparado");
            Console.WriteLine("5. Editar último mantenimiento de un vehículo");
            Console.WriteLine("6. Salir");
            Console.Write("\nSeleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarVehiculo(localReparacion);
                    break;
                case "2":
                    localReparacion.ListarVehiculos();
                    break;
                case "3":
                    ListarVehiculosPorCategoria(localReparacion);
                    break;
                case "4":
                    MarcarReparado(localReparacion);
                    break;
                case "5":
                    EditarUltimoMantenimiento(localReparacion);
                    break;
                case "6":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void AgregarVehiculo(LocalReparacion localReparacion)
    {
        Console.WriteLine("\nIngrese los detalles del vehículo:");

        Console.Write("Tipo de vehículo (automóvil, bicicleta, autobús): ");
        string tipo = Console.ReadLine();

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Último mantenimiento (YYYY-MM-DD): ");
        DateTime ultimoMantenimiento;
        if (!DateTime.TryParse(Console.ReadLine(), out ultimoMantenimiento))
        {
            Console.WriteLine("Fecha inválida. Se utilizará la fecha actual.");
            ultimoMantenimiento = DateTime.Now;
        }

        localReparacion.AgregarVehiculo(new Vehiculo(tipo, marca, modelo, ultimoMantenimiento));
        Console.WriteLine("Vehículo agregado correctamente.");
    }

    static void ListarVehiculosPorCategoria(LocalReparacion localReparacion)
    {
        Console.Write("\nIngrese la categoría de vehículo a listar: ");
        string categoria = Console.ReadLine();
        Console.WriteLine($"\nListado de vehículos de la categoría {categoria}:");
        localReparacion.ListarVehiculosPorCategoria(categoria);
    }

    static void MarcarReparado(LocalReparacion localReparacion)
    {
        Console.Write("\nIngrese el tipo de vehículo: ");
        string tipo = Console.ReadLine();

        Console.Write("Ingrese la marca del vehículo: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese el modelo del vehículo: ");
        string modelo = Console.ReadLine();

        localReparacion.MarcarReparado(tipo, marca, modelo);
    }

    static void EditarUltimoMantenimiento(LocalReparacion localReparacion)
    {
        Console.Write("\nIngrese el tipo de vehículo: ");
        string tipo = Console.ReadLine();

        Console.Write("Ingrese la marca del vehículo: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese el nuevo último mantenimiento (YYYY-MM-DD): ");
        DateTime nuevoMantenimiento;
        if (!DateTime.TryParse(Console.ReadLine(), out nuevoMantenimiento))
        {
            Console.WriteLine("Fecha inválida. No se realizó ninguna actualización.");
            return;
        }


        localReparacion.EditarUltimoMantenimiento(tipo, marca,  nuevoMantenimiento);
    }
}