using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IRecibirDaño,IMorir,IAtacable
{
    string nombre;
    int vida;
    int daño_p;
    int durabilidad;

    public string Nombre => nombre;
    public int Vida => vida;
    public int DañoP => daño_p;
    public int Durabilidad => durabilidad;

    public Player(string nombre, int daño, int durabilidad)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.daño_p = daño;
        this.durabilidad = durabilidad;
    }

    public Player(string nombre, int vida, int daño, int durabilidad) 
    {   this.nombre = nombre;
        this.vida = vida;
        this.daño_p = daño;
        this.durabilidad = durabilidad;
    }

    public void Atacar(IRecibirDaño objetivo)
    {
        try
        {
            if (durabilidad <= 0)
            {
                durabilidad = 0;
                throw new Exception("El arma del jugador está rota.");
            }

                int dañoAleatorio = UnityEngine.Random.Range(daño_p - 5,daño_p + 10);
                int desgaste = UnityEngine.Random.Range(1, 3);

                Debug.Log($"{nombre} ataca con {dañoAleatorio} de daño.");
                objetivo.RecibirDaño(dañoAleatorio);

                durabilidad -= desgaste;
                durabilidad = Mathf.Max(durabilidad - desgaste, 0);
            Debug.Log($"Durabilidad restante: {durabilidad}");
        }
        
        catch (Exception e)
        {
            Debug.LogErrorFormat($" Error durante el ataque: {e.Message}");
        }
    }


    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
        if (vida <= 0)
        {
            vida = 0;
            Morir();
        }
    }

    public void Morir()
    {
         throw new Exception($"{nombre} ha muerto.");
    }

}
