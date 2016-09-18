using UnityEngine;
using System.Collections;

public class LockMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Input.GetKey(KeyCode.Escape))
            Screen.lockCursor = false;
        else
            Screen.lockCursor = true;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Escape))
            Screen.lockCursor = false;
        else
            Screen.lockCursor = true;

    }
}
