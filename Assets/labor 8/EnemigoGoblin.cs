using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGoblin : Enemigo, IAtacable, IMorir
{
    bool isDead= false;
    public EnemigoGoblin(string nombre,int da�o) : base(nombre, da�o){ }

    public void Atacar(IRecibirDa�o objetivo)
    {
        
        try
        {
            if (isDead)
            {
                throw new Exception($"{Nombre} no puede atacar, est� muerto.");  
            }

            int da�oReal = UnityEngine.Random.Range(Da�oE - 3, Da�oE + 5);

            Debug.Log($"{Nombre} ataca con {da�oReal} de da�o.");
            objetivo.RecibirDa�o(da�oReal);
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
