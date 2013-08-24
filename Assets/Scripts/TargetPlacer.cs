using UnityEngine;
using System.Collections;

public class TargetPlacer : MonoBehaviour {
	public Transform targetPlacement;
	public GameObject targetPrefab;
	
	public int rows = 5;
	public int columns = 5;
	public int layers = 1;
	public float xSpacing = 1.5f;
	public float ySpacing = 1.5f;
	public float zSpacing = 1.5f;
	
	public Material[] materials;
	public int[] randomMaterials;
	
	// Use this for initialization
	void Start () {
		float width = (columns - 1) * xSpacing;
		float height = (rows - 1) * ySpacing;
		float depth = (layers - 1) * zSpacing;
		float xOffset = width / 2;
		float yOffset = height / 2;
		float zOffset = depth / 2;
		
		for(int x = 0; x < columns; x++) {
			for(int y = 0; y < rows; y++) {
				for(int z = 0; z < layers; z++) {
					Vector3 pos = new Vector3(targetPlacement.position.x - xOffset + (x * xSpacing), targetPlacement.position.y - zOffset + (z * zSpacing),
						targetPlacement.position.z - yOffset + (y * ySpacing));
					GameObject target = (GameObject)GameObject.Instantiate(targetPrefab, pos, targetPlacement.rotation);
					int colorIndex = randomMaterials[Random.Range(0, randomMaterials.Length)];
					target.renderer.material = materials[colorIndex];
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
