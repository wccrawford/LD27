using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	public float rotationSpeed = 5f;
	
	private float currentRotation = 0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentRotation = (currentRotation + (Time.deltaTime * rotationSpeed)) % 360;
		
		transform.localEulerAngles = new Vector3(0f, currentRotation, 0f);
	}
}
