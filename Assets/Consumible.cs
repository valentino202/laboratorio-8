using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumible : Item, IConsumible
{
    int cantidadCuracion;

    public Consumible(string nombre, int curacion) : base(nombre)
    {
        cantidadCuracion = curacion;
    }

    public void Consumir()
    {
        Debug.Log($"Usando {Nombre}, cura {cantidadCuracion} de vida.");
    }
}




