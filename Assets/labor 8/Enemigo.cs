using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
public interface IAtacable
{
    void Atacar(IRecibirDa�o objetivo);
}

public interface IRecibirDa�o
{
    void RecibirDa�o(int cantidad);
}

public interface IDropearItems
{
    Item DropearItem();
}

  public interface IMorir
  { 
    void Morir();
  }

public class Enemigo : IRecibirDa�o, IDropearItems, IMorir
{
    string nombre;
    int salud;
    int nivel;
    int da�o_e;


    public string Nombre => nombre;
    public int Salud => salud;
    public int Nivel => nivel;
    public int Da�oE => da�o_e;


    public Enemigo(string nombre, int da�o)
    {
        this.nombre = nombre;
        this.salud = 100;
        this.da�o_e = da�o;
        this.nivel = 1;
    }

    public Enemigo(string nombre, int salud, int da�o, int nivel)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.da�o_e = da�o;
        this.nivel = nivel;
    }

    public virtual void RecibirDa�o(int cantidad)
    {
        salud -= cantidad;
        if (salud <= 0)
        {
            salud = 0;
            Morir();
        }
    }

    public virtual void Morir()
    {
        Debug.Log($"{nombre} ha muerto.");
    }



    protected Item itemADropear;
    public  Item DropearItem()
    {
        if (itemADropear != null)
            return itemADropear;

        return new Consumible("Poci�n com�n", 10);
    }
    public void SetItemADropear(Item item)
    {
        itemADropear = item;
    }

    
}

