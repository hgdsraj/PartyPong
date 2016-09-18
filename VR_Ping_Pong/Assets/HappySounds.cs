using UnityEngine;
using System.Collections;

public class HappySounds : MonoBehaviour {
    public GameObject BackBoard;
    public int count = 0;
    public int volume = 20;
    public AudioSource crowd;
    public AudioSource airhorn;
    // Use this for initialization
    void Start()
    {
        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
        crowd = allMyAudioSources[1];
        airhorn = allMyAudioSources[0];
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)  {

        if (col.gameObject.name == "PingBall")
        {
            count++;
            if(count == 3)
            {
                if (crowd.volume < 100)
                {
                    crowd.volume = crowd.volume + 1;
                }
                airhorn.Play();
                count = 0;
            }
        }

 
        

    }
}
