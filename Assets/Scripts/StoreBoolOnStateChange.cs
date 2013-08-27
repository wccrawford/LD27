using UnityEngine;
using System.Collections;

public class StoreBoolOnStateChange : MonoBehaviour {
	public string playerPrefsKey;
	
	void Start() {
		if(PlayerPrefs.HasKey(playerPrefsKey)) {
			Debug.Log("Has state " + playerPrefsKey);
			bool state = (PlayerPrefs.GetInt(playerPrefsKey) > 0);
			Debug.Log(state);
			UICheckbox cb = GetComponent<UICheckbox>();
			cb.isChecked = state;
		}
	}
	
	void OnActivate(bool state) {
		Debug.Log("state change " + playerPrefsKey);
		Debug.Log (state);
		PlayerPrefs.SetInt(playerPrefsKey, (state ? 1 : 0));
	}
}
