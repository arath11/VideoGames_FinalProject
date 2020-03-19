using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public GameObject Bala;

    public Transform salidaBala;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotar cañon
        float v = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, v * 50 * Time.deltaTime, Space.World); 

    }
}
