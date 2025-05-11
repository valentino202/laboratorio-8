using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConsumible
{
    void Consumir();
}
public interface IAplicarBuff
{
    void Aplicar();
}
public class Item
{
    string nombre;

    public string Nombre => nombre;

    public Item(string nombre)
    {
        this.nombre = nombre;
    }

}
