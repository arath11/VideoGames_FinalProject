using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilLakitu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag=="Ground" || c.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
