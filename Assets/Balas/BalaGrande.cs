using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaGrande : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidadDisparo = 10;
    private int vida = 3;

    // Start is called before the first frame update
    void Start()
    {
        //referencia 
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.up * velocidadDisparo, ForceMode.Impulse);
        Destroy(gameObject, 3);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision c)
    {

        //Destruir PruebaLadrillo
        if (c.transform.name == "EnemigoSeguidor" || c.transform.name == "Enemigo3Dir" || c.transform.name == "Enemigo2Dir")
        {
            Destroy(c.gameObject);

            //Destruir bala
            if (vida < 1)
            {
                Destroy(gameObject);
            }
            else
            {
                vida--;
            }


        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}


