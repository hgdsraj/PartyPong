using UnityEngine;
using System.Collections;

public class coll : MonoBehaviour {

 void OnCollisionStay(Collision coll)
    {
        GetComponent<AudioSource>().Play();
    }
}
