using UnityEngine;
using System.Collections;

public class PlayIfPrefEnabled : MonoBehaviour {
	public string playerPrefsKey;
	
	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey(playerPrefsKey)) {
			PlayerPrefs.SetInt(playerPrefsKey, 1);
		}
		bool state = (PlayerPrefs.GetInt(playerPrefsKey) > 0);
		if(state) {
			audio.Play();
		}
	}
	
}
