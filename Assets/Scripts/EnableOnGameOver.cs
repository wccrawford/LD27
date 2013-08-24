using UnityEngine;
using System.Collections;

public class EnableOnGameOver : MonoBehaviour {
	public GameObject[] objects;
	public bool enable = true;
	
	void OnGameOver() {
		for(int i = 0; i < objects.Length; i++) {
			objects[i].SetActive(enable);
		}
	}
}
