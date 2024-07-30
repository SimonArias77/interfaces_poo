using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces_POO.Interfaces;

namespace Interfaces_POO.Models;

public class Leon : Animal, IAnimal
{
    public bool Melana { get; set; }

    public Leon(string nombre, double pesoKg, bool melena)
    : base(nombre, pesoKg)
    {
        Melana = melena;
    }

    public void Comer()
    {

    }

    public void Dormir()
    {

    }

    public override void Respirar()
    {

    }

    public void Desplazar()
    {

    }
}
