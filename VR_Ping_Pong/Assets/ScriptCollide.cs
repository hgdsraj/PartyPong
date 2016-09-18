using UnityEngine;
using System.Collections;

public class ScriptCollide : MonoBehaviour {
    public AudioSource audio;
    public float moveSpeed;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            audio.Play();

    }
    
    void Update()
    {
        if (Input.GetKey("q"))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey("e"))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

    }
}
