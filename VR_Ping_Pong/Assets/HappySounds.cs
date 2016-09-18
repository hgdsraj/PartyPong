using UnityEngine;
using System.Collections;
public static class GlobalVariables
{
    public static int score = 0;
    public static bool boolStreak = true;
    public static int streak = 0;
}

public class HappySounds : MonoBehaviour {
    public GameObject BackBoard;
    public int volume = 20;
    public int count = 0;
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
            GlobalVariables.score++;
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
            if(GlobalVariables.boolStreak == true)
            {
                GlobalVariables.streak++;
            }
        }

 
        

    }
}
