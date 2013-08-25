using UnityEngine;
using System.Collections;

public class UnlockCursor : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		Screen.lockCursor = false;
		enabled = false;
	}
}
