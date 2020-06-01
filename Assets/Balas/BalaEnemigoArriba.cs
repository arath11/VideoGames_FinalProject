using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigoArriba : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadDisparo = 3000;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * velocidadDisparo, ForceMode2D.Impulse);
        Destroy(gameObject, 5);



    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D c)
    {
        Destroy(gameObject);

    }

}