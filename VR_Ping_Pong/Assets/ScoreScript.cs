using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    void Start () {
        transform.GetComponent<TextMesh>().text = "Total: 0";
    }

	// Update the score text
	void Update () {
		transform.GetComponent<TextMesh> ().text = "Total: " + GlobalVariables.score;
	}
}
