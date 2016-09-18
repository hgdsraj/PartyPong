using UnityEngine;
using System.Collections;

public class SwingAnimation : MonoBehaviour {

	public void swing() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        Animation animation = GetComponent<Animation>();
        animation["Swing3"].speed = 4f;
        animation.Play();
	}
}
