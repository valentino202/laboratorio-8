using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGoblin : Enemigo, IAtacable, IMorir
{
    bool isDead= false;
    public EnemigoGoblin(string nombre,int daño) : base(nombre, daño){ }

    public void Atacar(IRecibirDaño objetivo)
    {
        
        try
        {
            if (isDead)
            {
                throw new Exception($"{Nombre} no puede atacar, está muerto.");  
            }

            int dañoReal = UnityEngine.Random.Range(DañoE - 3, DañoE + 5);

            Debug.Log($"{Nombre} ataca con {dañoReal} de daño.");
            objetivo.RecibirDaño(dañoReal);
        }
        catch (Exception e)

        {
            Debug.LogAssertion($" El conbate error muerto: {e.Message}");
        }

    }

    public override void Morir()
    {
        isDead = true;
        Debug.Log($"{Nombre} ha muerto.");
    }
}
