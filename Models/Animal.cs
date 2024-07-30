using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Interfaces_POO.Models;

public abstract class Animal
{
    public string Nombre { get; set; }
    public double PesoKg { get; set; }

    public Animal(string nombre, double pesoKg)
    {
        Nombre = nombre;
        PesoKg = pesoKg;
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }

    public void Caminar()
    {
        Console.WriteLine($"{Nombre} está reproduciendo.");
    }

    public abstract void Respirar();
}
