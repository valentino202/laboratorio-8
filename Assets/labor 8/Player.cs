using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IRecibirDa�o,IMorir,IAtacable
{
    string nombre;
    int vida;
    int da�o_p;
    int durabilidad;

    public string Nombre => nombre;
    public int Vida => vida;
    public int Da�oP => da�o_p;
    public int Durabilidad => durabilidad;

    public Player(string nombre, int da�o, int durabilidad)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.da�o_p = da�o;
        this.durabilidad = durabilidad;
    }

    public Player(string nombre, int vida, int da�o, int durabilidad) 
    {   this.nombre = nombre;
        this.vida = vida;
        this.da�o_p = da�o;
        this.durabilidad = durabilidad;
    }

    public void Atacar(IRecibirDa�o objetivo)
    {
        try
        {
            if (durabilidad <= 0)
            {
                durabilidad = 0;
                throw new Exception("El arma del jugador est� rota.");
            }

                int da�oAleatorio = UnityEngine.Random.Range(da�o_p - 5,da�o_p + 10);
                int desgaste = UnityEngine.Random.Range(1, 3);

                Debug.Log($"{nombre} ataca con {da�oAleatorio} de da�o.");
                objetivo.RecibirDa�o(da�oAleatorio);

                durabilidad -= desgaste;
                durabilidad = Mathf.Max(durabilidad - desgaste, 0);
            Debug.Log($"Durabilidad restante: {durabilidad}");
        }
        
        catch (Exception e)
        {
            Debug.LogErrorFormat($" Error durante el ataque: {e.Message}");
        }
    }


    public void RecibirDa�o(int cantidad)
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
