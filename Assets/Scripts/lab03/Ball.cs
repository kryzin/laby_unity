using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float force = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // ustawienie obiektu w pozycji (0, 0, 0)
        // transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
