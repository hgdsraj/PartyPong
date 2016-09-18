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
    public float duration = 0.2F;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;
    public Light lt;
    private bool passed = false;


    // Use this for initialization
    void Start()
    {
        lt = GetComponent<Light>();
        AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
        crowd = allMyAudioSources[1];
        airhorn = allMyAudioSources[0];

    }
    void Update()
    {
        if(passed == true)
        {
            float t = Mathf.PingPong(Time.time, duration) / duration;
            lt.color = Color.Lerp(color0, color1, t);
        }
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision col)  {

        if (col.gameObject.name == "PingBall")
        {
            GlobalVariables.score++;
            count++;
            if (count == 3)
            {

                airhorn.Play();
                passed = true;
                count = 0;
                }
               
            }

  
            
            if (GlobalVariables.boolStreak == true)
            {
                GlobalVariables.streak++;
            }
        }

 
        

    }

