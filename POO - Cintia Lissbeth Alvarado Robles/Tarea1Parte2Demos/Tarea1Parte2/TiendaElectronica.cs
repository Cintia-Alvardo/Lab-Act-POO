using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1Parte2;

public class TiendaElectronica
{
    public string NombreTienda { get; set; }
    private List<Producto> Productos { get; set; }

    public TiendaElectronica(string nombreTienda)
    {
        NombreTienda = nombreTienda;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void ListarProductos()
    {
        Console.WriteLine($"Productos disponibles en {NombreTienda}:");
        foreach (var producto in Productos)
        {
            Console.WriteLine(producto);
        }
    }

    public static void AbrirTienda(string nombre)
    {
        Console.WriteLine($"Bienvenidos a la tienda {nombre}!");
    }
}
