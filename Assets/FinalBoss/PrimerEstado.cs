using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerEstado : MonoBehaviour
{
    //private float speed = -2f;
   /* private bool isAlive = true;
    private int cont;
    private float dir = 1f;

    private Rigidbody2D rb2d;*/

   // public GameObject Bala1;

    public GameObject Bala2;

    public Transform salidaBala1;

   // public Transform salidaBala2;


 //   private bool IsLookingRight = false;
    /*
    private bool seVe=false;
    private bool corrut=false;
    */


    //public Transform[] vecinos;

    //public float velocidad = 3;

//    private int nodoActual;

  //  public float rangoValido = .01f;



    void Start()
    {
        //  rb2d = GetComponent<Rigidbody2D>();
        StartCoroutine("disparo");
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (seVe){
          StartCoroutine("disparo");
        }*/

        //modificar movimiento con waypoints
        //eliminar is alive
      //  cont++;
        //if (isAlive)
        //{
            /*transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
            if (cont == 70)
            {
                cont = 0;
                speed = -speed;
                //dir=-dir;
                //transform.localScale=new Vector3(dir,1f,1f);
                IsLookingRight = !IsLookingRight;
                transform.Rotate(0f, 180f, 0f);
            }*/
    //    }
    }
    IEnumerator disparo()
    {
        while (true)
        {
            Instantiate(Bala2,
                   salidaBala1.position,
                   salidaBala1.rotation
                   );
            /*   if (IsLookingRight)
               {

                   Instantiate(Bala1,
                      salidaBala1.position,
                      salidaBala1.rotation
                      );

               }
               else
               {
                   Instantiate(Bala2,
                      salidaBala1.position,
                      salidaBala1.rotation
                      );

               }
               */


            /* Instantiate(Bala1,
                   salidaBala2.position,
                   salidaBala2.rotation
                   );*/
            yield return new WaitForSeconds(1.2f);
        }
    }


    /* IEnumerator VerificarWayPoint() {
         while (true)
         {

             //checar disancia
             float distancia = Vector3.Distance(transform.position, vecinos[nodoActual].transform.position);

             //llegamos y cambiamos de objetivo
             if (distancia < rangoValido)
             {
                 nodoActual++;
                 //ajuste con modulo
                 nodoActual %= vecinos.Length;
                 transform.Rotate(0f, 180f, 0f);
             }

             yield return new WaitForSeconds(.3f);
         }
     }*/
    void OnBecameInvisible()
    {
        StopCoroutine("disparo");
        /*seVe = false;
        corrut = false;*/
    }


    void OnBecameVisible()
    {

        StartCoroutine("disparo");
        /*  seVe =true;
           corrut= true;*/
    }

}

