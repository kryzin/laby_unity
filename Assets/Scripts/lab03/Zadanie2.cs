using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2 : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if(rb.position.x >= 10)
        {
            GoBack();
        }
        // jakby miała być pętelka
        // if(rb.position.x < 0)
        // {
        //     Start();
        // }
    }

    void GoBack()
    {
        // start at 10/0/0, use the same speed
        transform.position = new Vector3(10.0f, 0.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-speed, 0, 0, ForceMode.Impulse);
    }
}
