using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePersonaje : MonoBehaviour
{

    public Text textito;

    public float vida=10;

    private string texto;

    public GameObject Bala1;
    
    public GameObject BalaGrande;

    public GameObject BalaCaida1;

    public Transform salidaBala1;

    public Transform salidaBala2;
    
    public Transform salidaBala3;

    public Transform caidaBala;

    public float velocidadBala1 = .1f;


    // Start is called before the first frame update
    void Start()
    {
        this.texto = vida.ToString("R");
        this.textito.text = texto;

    }

    // Update is called once per frame
    void Update()
    {
        this.texto = vida.ToString("R");
        this.textito.text = texto;


        //mover
        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * 5 * Time.deltaTime, 0, 0, Space.World);
       
        //disparos
        //disparoBala1
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("disparoBala1");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine("disparoBala1");

        }

        //disparoBala2
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine("disparoBala2");
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            StopCoroutine("disparoBala2");

        }

        //disparoBalaGrande
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine("disparoBalaGrande");
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            StopCoroutine("disparoBalaGrande");

        }


        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("CaidaBala");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            StopCoroutine("CaidaBala");

        }


        //salto
        if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.Translate(
                0, 100 * Time.deltaTime, 0, Space.World);

        }

    }

    void OnCollisionEnter(Collision c)
    {
        
        if (c.transform.name == "BalaEnemigo(Clone)") {
            vida--;
            print(vida);
        }
        
    }


    IEnumerator disparoBala1() {
        while (true) {
            Instantiate(Bala1,
                   salidaBala1.position,
                   salidaBala1.rotation
                   );
            yield return new WaitForSeconds(velocidadBala1);
        }
    }

    IEnumerator disparoBala2()
    {
        while (true)
        {
            Instantiate(Bala1,
                   salidaBala1.position,
                   salidaBala1.rotation
                   );
            Instantiate(Bala1,
                   salidaBala2.position,
                   salidaBala2.rotation
                   );
            Instantiate(Bala1,
                   salidaBala3.position,
                   salidaBala3.rotation
                   );
            yield return new WaitForSeconds(velocidadBala1*2);
        }
    }

    IEnumerator disparoBalaGrande()
    {
        while (true)
        {
            Instantiate(BalaGrande,
                   salidaBala1.position,
                   salidaBala1.rotation
                   );
            yield return new WaitForSeconds(2.0f);
        }
    }

    IEnumerator CaidaBala()
    {
        while (true)
        {
            Instantiate(BalaCaida1,
                   caidaBala.position,
                   caidaBala.rotation
                   );
            yield return new WaitForSeconds(2.0f);
        }
    }

}
