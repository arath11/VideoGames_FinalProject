using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2Dir : MonoBehaviour
{
    public GameObject Bala1;

    public Transform salidaBala1;

    public Transform salidaBala2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("disparoBala2");
    }

    // Update is called once per frame
    void Update()
    {
        //disparo
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StartCoroutine("disparoBala2");
        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            StopCoroutine("disparoBala2");

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
            yield return new WaitForSeconds(2.0f);
        }
    }

}
