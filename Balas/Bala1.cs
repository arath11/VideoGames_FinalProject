using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1 : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidadDisparo = 10;
    public float destruir = 2;

    // Start is called before the first frame update
    void Start()
    {
        //referencia
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * velocidadDisparo, ForceMode.Impulse);
        Destroy(gameObject, destruir);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Collision2D(Collision c)
    {
        //Destruir bala
        Destroy(gameObject);

        //Destruir ENEMIGO
        if (c.gameObject.tag=="Enemigo"){
            Destroy(c.gameObject);
        }

       // print(c.transform.name);

    }
    void OnCollisionStay2D(Collision2D colision)
    {

        Destroy(gameObject);

        if (colision.gameObject.tag == "Enemigo")
        {
          Destroy(colision.gameObject);
        }
    }


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
