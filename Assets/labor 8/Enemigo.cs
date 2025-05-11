using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;
public interface IAtacable
{
    void Atacar(IRecibirDaño objetivo);
}

public interface IRecibirDaño
{
    void RecibirDaño(int cantidad);
}

public interface IDropearItems
{
    Item DropearItem();
}

  public interface IMorir
  { 
    void Morir();
  }

public class Enemigo : IRecibirDaño, IDropearItems, IMorir
{
    string nombre;
    int salud;
    int nivel;
    int daño_e;


    public string Nombre => nombre;
    public int Salud => salud;
    public int Nivel => nivel;
    public int DañoE => daño_e;


    public Enemigo(string nombre, int daño)
    {
        this.nombre = nombre;
        this.salud = 100;
        this.daño_e = daño;
        this.nivel = 1;
    }

    public Enemigo(string nombre, int salud, int daño, int nivel)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.daño_e = daño;
        this.nivel = nivel;
    }

    public virtual void RecibirDaño(int cantidad)
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

        return new Consumible("Poción común", 10);
    }
    public void SetItemADropear(Item item)
    {
        itemADropear = item;
    }

    
}

