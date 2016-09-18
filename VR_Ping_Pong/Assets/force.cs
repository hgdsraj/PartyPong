using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;

    void Start() 
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);

    }



    void FixedUpdate() 
    {
    }
}
