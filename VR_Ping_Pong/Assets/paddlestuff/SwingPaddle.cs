using UnityEngine;
using System.Collections;

public class SwingPaddle : MonoBehaviour {

	public SwingAnimation SwingAnim;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			SwingAnim.swing();
		}
	
	}
}
