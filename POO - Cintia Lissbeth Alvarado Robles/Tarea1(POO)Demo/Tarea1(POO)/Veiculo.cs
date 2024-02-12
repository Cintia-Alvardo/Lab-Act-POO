using System;

public class Vehiculo
{
    public string Tipo { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime UltimoMantenimiento { get; set; }
    public bool Reparado { get; set; }

    public Vehiculo(string tipo, string marca, string modelo, DateTime ultimoMantenimiento, bool reparado = false)
    {
        Tipo = tipo;
        Marca = marca;
        Modelo = modelo;
        UltimoMantenimiento = ultimoMantenimiento;
        Reparado = reparado;
    }
}
