// Author: Adam Pruner for Hack the North 2016


using UnityEngine;
using System.Collections;

// Script adapted from Marzoa's script (who borrowed it from DMTSource)
// Script is posted publicly on the Unity Asset Store

public class AudienceLoop : MonoBehaviour {

	private string[] names = { "applause", "applause2", "celebration", "celebration2", "celebration3" };

	// Use this for initialization
	void Start () {
		Animation[] AudienceMembers = gameObject.GetComponentsInChildren<Animation> ();
		foreach (Animation anim in AudienceMembers) {
			int anim_num = Random.Range (0, 4);
			string thisAnimation = names[anim_num];
			anim.wrapMode = WrapMode.Loop;
			anim.GetComponent<Animation> ().CrossFade (thisAnimation);
			anim [thisAnimation].time = Random.Range (0f, 3f);
		}
			
	}

}
