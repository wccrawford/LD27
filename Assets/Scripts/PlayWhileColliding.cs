using UnityEngine;
using System.Collections;

public class PlayWhileColliding : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
		audio.Play();
	}
	
	void OnCollisionExit(Collision collision) {
		audio.Pause();
	}
	
	void Update() {
		if(rigidbody.IsSleeping() && audio.isPlaying) {
			audio.Pause();
		}
	}
}
