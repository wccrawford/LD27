using UnityEngine;
using System.Collections;

public class LoadSceneOnClick : MonoBehaviour {
	public int sceneNumber = -1;
	
	void OnClick () {
		if(sceneNumber == -1) {
			Application.LoadLevel(Application.loadedLevel);
		} else {
			Application.LoadLevel(sceneNumber);
		}
	}
}
