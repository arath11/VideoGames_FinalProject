using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSimple : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadDisparo = 3000;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * velocidadDisparo, ForceMode2D.Impulse);
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D c)
    {
        Destroy(gameObject);
        if (c.gameObject.tag == "Enemigo")
        {
          Destroy(c.gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
