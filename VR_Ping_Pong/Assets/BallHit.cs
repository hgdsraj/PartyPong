using UnityEngine;
using System.Collections;

public class BallHit : MonoBehaviour {
    public GameObject PingBall;

    // Use this for initialization
    void Start () {
	
	}
    void OnCollisionEnter(Collision col)  //Plays Sound Whenever collision detected
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        
        if (col.gameObject.name == "Ground")
        {

            this.transform.position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(5.0f, 10.0f),0);
            rb.velocity = new Vector3(0,0,Random.Range(-5.0f,-10.0f));
            GlobalVariables.boolStreak = false;
            GlobalVariables.streak = 0;
            GlobalVariables.score = 0;
        }

        if (col.gameObject.name == "Paddle")
        {

            
           rb.velocity = new Vector3(0, 0, 20.0f);



        }
        GetComponent<AudioSource>().Play();
    }
    // Update is called once per frame
    void Update () {
	
	}
}
