using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Barker : MonoBehaviour {
	public AudioClip[] audioClips;
	
	public float delay = 5f;
	
	private float delayLeft = 1f;
	
	private string playerPrefsKey = "PrefBarkerPlay";
	
	void Start() {
		if(!PlayerPrefs.HasKey(playerPrefsKey)) {
			PlayerPrefs.SetInt(playerPrefsKey, 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		delayLeft -= Time.deltaTime;
		if(delayLeft <= 0f) {
			bool playBarker = (PlayerPrefs.GetInt(playerPrefsKey) > 0);
			if(playBarker) {
				AudioClip clip = audioClips[Random.Range(0, audioClips.Length)];
				audio.PlayOneShot(clip);
				delayLeft = delay + clip.length;
			}
		}
	}
}
