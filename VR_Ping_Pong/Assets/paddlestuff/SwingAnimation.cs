using UnityEngine;
using System.Collections;

public class SwingAnimation : MonoBehaviour {

	public void swing() {
		GetComponent<Animation> ().Play();
	}
}
