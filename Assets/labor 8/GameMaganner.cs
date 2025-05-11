using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaganner : MonoBehaviour
{
    Player Jugador;
    EnemigoGoblin Goblin;
    bool combateFinalizado = false;
    void Start()
    {
        Jugador = new Player("Heroe",30,4);
        Goblin = new EnemigoGoblin("Rey Goblin",15);
        


      //  EnemigoGoblin goblin = new EnemigoGoblin("Goblin Verde",40);
       // EnemigoGoblin goblin2 = new EnemigoGoblin("Goblin Azul",30);
       // Enemigo orco = new Enemigo("Orco", 150, 2, 20);

        
       // goblin2.SetItemADropear(new Consumible("Poción grande", 50));

       
       // goblin.Atacar(orco);


      //  Buff a = new Buff("furia","Aumenta el daño en 20 por 3 turnos" );
      //  a.Aplicar();
      //  Consumible pocion = new Consumible("Poción fuerte", 500);
      //  pocion.Consumir();

        
       // Item drop = goblin.DropearItem();
       // Item drop2 = goblin2.DropearItem();

       // Debug.Log("El goblin dejó: " + drop.Nombre);
       // Debug.Log("El goblin azul dejó: " + drop2.Nombre);


       // ItemUsar.ConsumirItemSiEsPosible(drop);//
       // ItemUsar.ConsumirItemSiEsPosible(drop2);//

    }
     void Update()
     {
        if(Input.GetKeyDown(KeyCode.A) && !combateFinalizado)
        {
            try
            {
                Debug.Log("inicia el combate");
                Jugador.Atacar(Goblin);
                Goblin.Atacar(Jugador);

                if (Goblin.Salud <= 0 || Jugador.Vida <= 0 )
                {
                    combateFinalizado = true;
                    Debug.Log(" Combate finalizado.");

                    if (Goblin.Salud <= 0)
                        Debug.Log(" El jugador ha ganado.");
                    else if (Jugador.Vida <= 0)
                        Debug.Log(" El jugador ha muerto. Fin del juego.");
                    
                }

            }
            catch(System.Exception e) 
            
            {
                Debug.LogError($" Error: {e.Message}");

            }


        }

     } 

}
