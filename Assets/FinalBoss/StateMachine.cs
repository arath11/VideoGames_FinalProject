using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    private Rigidbody2D rb2d;

    //Carta random
    public MonoBehaviour EstadoUno;
    //(Si gano) utilizar una carta de un elemento distinto al usado
    public MonoBehaviour EstadoDos;
    //(Si perdió) utilizar hielo si el oponente uso fuego, usar fuego si el oponente uso agua, usar agua si el oponente uso hielo
    public MonoBehaviour EstadoTres;
    //Cuando le falta un elemento para ganar , 80% de probabilidad de usar ese elemento que le falta
    //public MonoBehaviour EstadoVictorioso;
    //Cuando al jugador le falta un elemento, 80% de probabilidad de utilizar el elemento que le gana al que le hace falta al jugador
    //public MonoBehaviour EstadoAgresivo;

    private MonoBehaviour estadoActual;

    public int vida=20;

    // Start is called before the first frame update
    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();

        activarEstado(EstadoUno);
        print(estadoActual);
    }

    public void Update()
    {
/*
        if (Input.GetKeyDown(KeyCode.Z))
        {
            activarEstado(EstadoUno);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            activarEstado(EstadoDos);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            activarEstado(EstadoTres);
        }

  if (Input.GetKeyDown(KeyCode.P))
        {
            vida--;
            print(vida);
            if (vida == 0) {
                Destroy(gameObject);
            }
        }*/

    }

    public void activarEstado(MonoBehaviour nuevoEstado)
    {
        if (estadoActual != null)
        {
            estadoActual.enabled = false;
        }
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }

    
    void OnCollisionExit2D(Collision2D c)
    {
        //print(c.gameObject.name);
        if (c.gameObject.tag == "BalaJugador")
        {
          
            vida--;
            if (vida == 13)
            {
        
                activarEstado(EstadoDos);
                print(estadoActual);
                vida = 12;
            }
            else if (vida == 8)
            {

                activarEstado(EstadoTres);
                print(estadoActual);
                vida = 7;
            }
            else if(vida==0){
                Destroy(gameObject);

            }


      
            
        }

    }

}