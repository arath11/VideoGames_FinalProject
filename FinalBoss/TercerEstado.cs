using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TercerEstado : MonoBehaviour
{
    //private float speed = -2f;
    /* private bool isAlive = true;
     private int cont;
     private float dir = 1f;

     private Rigidbody2D rb2d;*/

    // public GameObject Bala1;

    public GameObject Bala2;

    public Transform salidaBala1;

    public Transform salidaBala2;

    public Transform salidaBala3;

    public Transform salidaBala4;

    public Transform salidaBala5;


    public Transform salidaBala6;

    public Transform salidaBala7;

    public Transform salidaBala8;

    public Transform salidaBala9;

    public Transform salidaBala10;

    private bool esPar = true;

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
            if (esPar)
            {
                Instantiate(Bala2,
                   salidaBala1.position,
                   salidaBala1.rotation
                   );

                Instantiate(Bala2,
                   salidaBala2.position,
                   salidaBala2.rotation
                   );

                Instantiate(Bala2,
                   salidaBala3.position,
                   salidaBala3.rotation
                   );

                Instantiate(Bala2,
                   salidaBala4.position,
                   salidaBala4.rotation
                   );

                Instantiate(Bala2,
                   salidaBala5.position,
                   salidaBala5.rotation
                   );

            }
            else {


                Instantiate(Bala2,
                   salidaBala6.position,
                   salidaBala6.rotation
                   );

                Instantiate(Bala2,
                   salidaBala7.position,
                   salidaBala7.rotation
                   );

                Instantiate(Bala2,
                   salidaBala8.position,
                   salidaBala8.rotation
                   );

                Instantiate(Bala2,
                   salidaBala9.position,
                   salidaBala9.rotation
                   );

                Instantiate(Bala2,
                   salidaBala10.position,
                   salidaBala10.rotation
                   );

            }
            esPar = !esPar;
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
            yield return new WaitForSeconds(3f);
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


        /*  seVe =true;
           corrut= true;*/
    }

}

