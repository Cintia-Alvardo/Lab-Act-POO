using System;
using System.Collections.Generic;

public class LocalReparacion
{
    private List<Vehiculo> vehiculos;

    public LocalReparacion()
    {
        vehiculos = new List<Vehiculo>();
    }

    public void AgregarVehiculo(Vehiculo vehiculo)
    {
        vehiculos.Add(vehiculo);
    }

    public void ListarVehiculos()
    {
        foreach (var vehiculo in vehiculos)
        {
            Console.WriteLine($"{vehiculo.Tipo}: {vehiculo.Marca} {vehiculo.Modelo} - Último mantenimiento: {vehiculo.UltimoMantenimiento} - Reparado: {(vehiculo.Reparado ? "Sí" : "No")}");
        }
    }

    public void ListarVehiculosPorCategoria(string categoria)
    {
        foreach (var vehiculo in vehiculos)
        {
            if (vehiculo.Tipo.ToLower() == categoria.ToLower())
            {
                Console.WriteLine($"{vehiculo.Tipo}: {vehiculo.Marca} {vehiculo.Modelo} - Último mantenimiento: {vehiculo.UltimoMantenimiento} - Reparado: {(vehiculo.Reparado ? "Sí" : "No")}");
            }
        }
    }

    public void MarcarReparado(string tipo, string marca, string modelo)
    {
        foreach (var vehiculo in vehiculos)
        {
            if (vehiculo.Tipo == tipo && vehiculo.Marca == marca && vehiculo.Modelo == modelo)
            {
                vehiculo.Reparado = true;
                Console.WriteLine($"El vehículo {tipo} {marca} {modelo} ha sido marcado como reparado.");
            }
        }
    }

    public void EditarUltimoMantenimiento(string tipo, string marca, string modelo, DateTime nuevoMantenimiento)
    {
        foreach (var vehiculo in vehiculos)
        {
            if (vehiculo.Tipo == tipo && vehiculo.Marca == marca && vehiculo.Modelo == modelo)
            {
                vehiculo.UltimoMantenimiento = nuevoMantenimiento;
                Console.WriteLine($"El último mantenimiento del vehículo {tipo} {marca} {modelo} ha sido actualizado.");
            }
        }
    }

    internal void EditarUltimoMantenimiento(string? tipo, string? marca, DateTime nuevoMantenimiento)
    {
        throw new NotImplementedException();
    }
}

