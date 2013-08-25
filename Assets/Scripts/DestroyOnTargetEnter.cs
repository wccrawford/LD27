using UnityEngine;
using System.Collections;

public class DestroyOnTargetEnter : MonoBehaviour {
	public AudioClip destroySound = null;
	
	private bool destroy = false;
	
	void Update() {
		if(destroy && !audio.isPlaying) {
			Destroy(gameObject);
		}
	}
	void OnTargetEnter() {
		if(destroySound != null) {
			renderer.enabled = false;
			audio.clip = destroySound;
			audio.Play();
		}
		destroy = true;
	}
}
