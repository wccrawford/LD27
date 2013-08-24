using UnityEngine;
using System.Collections;

public class BottlePlacer : MonoBehaviour {
	public Transform bottlePlacement;
	public GameObject bottlePrefab;
	
	public int rows = 5;
	public int columns = 5;
	public float spacing = 1.5f;
	
	public Material[] materials;
	public int[] randomMaterials;
	
	// Use this for initialization
	void Start () {
		float width = (columns - 1) * spacing;
		float height = (rows - 1) * spacing;
		float xOffset = width / 2;
		float yOffset = height / 2;
		
		for(int x = 0; x < columns; x++) {
			for(int y = 0; y < rows; y++) {
				Vector3 pos = new Vector3(bottlePlacement.position.x - xOffset + (x * spacing), bottlePlacement.position.y,
					bottlePlacement.position.z - yOffset + (y * spacing));
				GameObject bottle = (GameObject)GameObject.Instantiate(bottlePrefab, pos, bottlePlacement.rotation);
				int colorIndex = randomMaterials[Random.Range(0, randomMaterials.Length)];
				bottle.renderer.material = materials[colorIndex];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
