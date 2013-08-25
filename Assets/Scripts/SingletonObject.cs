using UnityEngine;
using System.Collections;

public class SingletonObject : MonoBehaviour {
	public string singletonName;
	
	// Use this for initialization
	void Start () {
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(singletonName);
		if(gameObjects.Length > 1) {
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
