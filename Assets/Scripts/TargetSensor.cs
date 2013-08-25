using UnityEngine;
using System.Collections;

public class TargetSensor : MonoBehaviour {
	public string tagName = "Target";
	
	//public bool subtractOnExit = true;
	
	//private GameObject currentTarget = null;
	
	//private GameManager gameManager;
	
	// Use this for initialization
	void Start () {
		//gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
			/*currentTarget = target.gameObject;
			TargetColor tc1 = transform.parent.GetComponentInChildren<TargetColor>();
			TargetColor tc2 = currentTarget.transform.parent.GetComponentInChildren<TargetColor>();
			if(tc1.getColorIndex() == tc2.getColorIndex()) {
				gameManager.addScore(10);
			} else {
				gameManager.addScore(1);
			}*/
			SendMessageUpwards("OnTargetEnter", target, SendMessageOptions.DontRequireReceiver);
		}
	}
	
	void OnTriggerExit(Collider target) {
		if(target.tag == tagName) {
			/*if(subtractOnExit) {
				TargetColor tc1 = transform.parent.GetComponentInChildren<TargetColor>();
				TargetColor tc2 = target.gameObject.transform.parent.GetComponentInChildren<TargetColor>();
				if(tc1.getColorIndex() == tc2.getColorIndex()) {
					gameManager.addScore(-10);
				} else {
					gameManager.addScore(-1);
				}
			}
			currentTarget = null;*/
			SendMessageUpwards("OnTargetExit", target, SendMessageOptions.DontRequireReceiver);
		}
	}
	
	/*public GameObject getCurrentTarget() {
		return currentTarget;
	}*/
}
