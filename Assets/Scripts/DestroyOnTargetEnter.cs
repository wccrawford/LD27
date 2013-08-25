using UnityEngine;
using System.Collections;

public class DestroyOnTargetEnter : MonoBehaviour {
	private bool destroy = false;
	
	void Update() {
		if(destroy) {
			Destroy(gameObject);
		}
	}
	void OnTargetEnter() {
		destroy = true;
	}
}
