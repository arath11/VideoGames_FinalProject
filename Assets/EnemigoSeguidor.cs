using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSeguidor : MonoBehaviour
{
    private Rigidbody rb;
    
    public Transform objetivo;

    public GameObject Bala1;

    public Transform salidaBalaEnemigo;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("disparoBalaEnemigo");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objetivo);


        //disparos
        //disparoBala1
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine("disparoBalaEnemigo");
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            StopCoroutine("disparoBalaEnemigo");

        }
    }


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    IEnumerator disparoBalaEnemigo()
    {
        while (true)
        {
            Instantiate(Bala1,
                   salidaBalaEnemigo.position,
                   salidaBalaEnemigo.rotation
                   );
            yield return new WaitForSeconds(2.0f);
        }
    }
}
