using UnityEngine;
using System.Collections;

public class EnableOnStandalone : MonoBehaviour {
	public GameObject[] objects;
	
	// Use this for initialization
	void Start () {
		for(int i = 0; i < objects.Length; i++) {
			objects[i].SetActive(false);
		}
		#if UNITY_STANDALONE
			for(int i = 0; i < objects.Length; i++) {
				objects[i].SetActive(true);
			}
		#endif
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
