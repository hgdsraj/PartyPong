using UnityEngine;
using System.Collections;

public class StreakScript : MonoBehaviour {

    public int greatestStreak = 0;

    void Start()
    {
        transform.GetComponent<TextMesh>().text = "High Score: 0";
    }

    // Update the score text
    void Update()
    {
        if (GlobalVariables.boolStreak == true)
        {
            if(GlobalVariables.streak > greatestStreak)
            {
                greatestStreak = GlobalVariables.streak;
            }
            transform.GetComponent<TextMesh>().text = "High Score: " + greatestStreak;
        } 
        else
        {
            GlobalVariables.boolStreak = true;
            GlobalVariables.streak = 0;
        }
    }
}
