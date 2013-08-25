using UnityEngine;
using System.Collections;

public class RingThrowController : MonoBehaviour {
	public Transform ringPlacement;
	public GameObject ringPrefab;
	public GameObject mouselookObject;
	
	public float minThrowForce = 100f;
	public float maxThrowForce = 1000f;
	
	public float delayAmount = 0.1f;
	
	public float mouseMultiplier = 10f;
	public float minMouselookX = -90f;
	public float minMouselookY = -45f;
	public float maxMouselookX = 90f;
	public float maxMouselookY = 45f;
	
	public PowerMeter powerMeter;
	
	public Material[] materials;
	public int[] randomMaterials;
	
	private float delay = 0f;
	private GameObject currentRing;
	private float throwForceTime = 0f;
	private float throwForce = 0f;
	private Quaternion ringRotation = Quaternion.identity;
	
	private float mouselookX = 0f;
	private float mouselookY = 0f;
	
	// Use this for initialization
	void Start () {
		ringRotation = mouselookObject.transform.rotation * ringPlacement.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		delay -= Time.deltaTime;

		if((delay <= 0.0f) && (currentRing == null)) {
			currentRing = (GameObject)GameObject.Instantiate(ringPrefab, ringPlacement.position, ringRotation);
			TargetColor tc = currentRing.GetComponentInChildren<TargetColor>();
			
			int colorIndex = randomMaterials[Random.Range(0, randomMaterials.Length)];
			//currentRing.renderer.material = materials[colorIndex];

			tc.setColorIndex(colorIndex);
			tc.setMaterial(materials[colorIndex]);
			
			delay = 0f;
		}
		
		if(currentRing != null) {
			if(Input.GetMouseButton(0)) {
				// Add force up to max
				throwForceTime += Time.deltaTime;
				throwForce = Mathf.Lerp(minThrowForce, maxThrowForce, throwForceTime);

				powerMeter.setLevel(Mathf.FloorToInt(throwForce / 200));
			}
			
			if(Input.GetMouseButtonUp(0)) {
				// Throw ring
				Rigidbody rb = currentRing.GetComponent<Rigidbody>();
				rb.isKinematic = false;
				rb.AddForce(mouselookObject.transform.forward * throwForce);
				
				currentRing = null;
				delay = delayAmount;
				throwForceTime = 0f;
				
				powerMeter.setLevel(0);
			}
		}
		
		if(Input.GetMouseButton(1)) {
			//ringRotation = ringRotation * Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseMultiplier, Vector3.up);
			ringRotation = ringRotation * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseMultiplier, Vector3.right);
			if(currentRing != null) {
				currentRing.transform.rotation = mouselookObject.transform.rotation * ringRotation;
			}
		} else {
			mouselookX = Mathf.Clamp(mouselookX - (Input.GetAxis("Mouse Y") * mouseMultiplier), minMouselookX, maxMouselookX);
			mouselookY = Mathf.Clamp(mouselookY + (Input.GetAxis("Mouse X") * mouseMultiplier), minMouselookY, maxMouselookY);
			
			mouselookObject.transform.localEulerAngles = new Vector3(mouselookX, mouselookY, 0f);
			
			if(currentRing != null) {
				currentRing.transform.position = ringPlacement.position;
				currentRing.transform.rotation = mouselookObject.transform.rotation * ringRotation;
			}
		}
	}
	
	public void OnGameOver() {
		Destroy(currentRing);
		currentRing = null;
		
		enabled = false;
	}
}
