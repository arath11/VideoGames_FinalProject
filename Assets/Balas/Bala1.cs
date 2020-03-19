using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1 : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidadDisparo=10;

    // Start is called before the first frame update
    void Start()
    {
        //referencia 
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.up * velocidadDisparo, ForceMode.Impulse);
        Destroy(gameObject, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
        //Destruir bala
        Destroy(gameObject);

        //Destruir PruebaLadrillo
        if (c.transform.name == "EnemigoSeguidor" || c.transform.name == "Enemigo3Dir" || c.transform.name == "Enemigo2Dir")
        {
            Destroy(c.gameObject);
        }
        

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}


