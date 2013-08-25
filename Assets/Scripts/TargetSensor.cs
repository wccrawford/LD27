using UnityEngine;
using System.Collections;

public class TargetSensor : MonoBehaviour {
	public string tagName = "Target";
	private GameObject currentTarget = null;
	
	private GameManager gameManager;
	
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		/*if((currentTarget != null) && (transform.parent.rigidbody.IsSleeping())) {
			gameManager.addScore(1);
			enabled = false;
		}*/
	}
	
	void OnTriggerEnter(Collider target) {
		if(target.tag == tagName) {
			currentTarget = target.gameObject;
			gameManager.addScore(1);
		}
	}
	
	void OnTriggerExit(Collider target) {
		if(target.tag == tagName) {
			currentTarget = null;
			gameManager.addScore(-1);
		}
	}
	
	public GameObject getCurrentTarget() {
		return currentTarget;
	}
}
