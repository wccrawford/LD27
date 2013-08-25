using UnityEngine;
using System.Collections;

public class StickOnTarget : MonoBehaviour {
	public string tagName = "Backboard";
	
	void OnTriggerEnter(Collider target) {
		if(target.tag == tagName) {
			transform.parent.rigidbody.isKinematic = true;
		}
	}
}
