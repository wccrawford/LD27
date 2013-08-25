using UnityEngine;
using System.Collections;

public class ScoreOnTarget : MonoBehaviour {
	public bool subtractOnExit = true;
	
	//private GameObject currentTarget = null;
	
	private GameManager gameManager;
	
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	void OnTargetEnter(Collider target) {
		//if(target.tag == tagName) {
			//currentTarget = target.gameObject;
			TargetColor tc1 = transform.parent.GetComponentInChildren<TargetColor>();
			TargetColor tc2 = target.gameObject.transform.parent.GetComponentInChildren<TargetColor>();
			if(tc1.getColorIndex() == tc2.getColorIndex()) {
				gameManager.addScore(10);
			} else {
				gameManager.addScore(1);
			}
		//}
	}
	
	void OnTargetExit(Collider target) {
		//if(target.tag == tagName) {
			if(subtractOnExit) {
				TargetColor tc1 = transform.parent.GetComponentInChildren<TargetColor>();
				TargetColor tc2 = target.gameObject.transform.parent.GetComponentInChildren<TargetColor>();
				if(tc1.getColorIndex() == tc2.getColorIndex()) {
					gameManager.addScore(-10);
				} else {
					gameManager.addScore(-1);
				}
			}
			//currentTarget = null;
		//}
	}
	
	/*public GameObject getCurrentTarget() {
		return currentTarget;
	}*/
}
