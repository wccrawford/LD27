using UnityEngine;
using System.Collections;

public class LockCursor : MonoBehaviour {
	
	void Start() {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape")) {
			Screen.lockCursor = false;
		}
		
		if(Input.GetMouseButtonDown(0)) {
			Screen.lockCursor = true;
		}
	}
}
