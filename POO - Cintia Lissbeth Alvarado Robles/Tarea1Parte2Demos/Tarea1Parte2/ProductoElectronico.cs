using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Tarea1Parte2;

public class ProductoElectronico : Producto
{
    public string Marca { get; set; }

    public ProductoElectronico(string nombre, double precio, string marca)
        : base(nombre, precio)
    {
        Marca = marca;
    }

    public override string ToString()
    {
        return $"{Nombre} ({Marca}) - ${Precio:0.00}";
    }
}
