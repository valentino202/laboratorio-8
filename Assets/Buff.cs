using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : Item, IAplicarBuff
{
     string efecto;

    public Buff(string nombre, string efecto) : base(nombre)
    {
        this.efecto = efecto;
    }

    public void Aplicar()
    {
        Debug.Log($"Aplicando buff: {efecto}.");
    }

}
