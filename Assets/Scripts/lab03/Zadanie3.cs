using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{
    public float speed = 1.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
        StartTurn();
    }

    // Update is called once per frame
    void Update()
    {
        float a = 0;
        rb = GetComponent<Rigidbody>();
        if(rb.position.x >= 10 && a==0)
        {
            a = 1;
            StartTurn();
        }
    }
    // D -- C
    // |    |
    // A -- B
    void StartTurn()
    {
        // start at 10/0/0, go to 10/0/10
        // transform.position = new Vector3(10.0f, 0.0f, 0.0f);
        transform.Rotate(0, -90, 0, Space.Self);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
    }
}
