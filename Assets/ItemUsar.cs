using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemUsar 
{
    public static void ConsumirItemSiEsPosible(Item item)
    {
        if (item is IConsumible consumible)
        {
            consumible.Consumir();
        }
        else
        {
            Debug.Log($"{item.Nombre} no es consumible.");
        }
    }

}
