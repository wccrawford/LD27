using UnityEngine;
using System.Collections;

public class TargetColor : MonoBehaviour {
	public GameObject[] paintedParts;
	
	private int colorIndex;
	
	public void setColorIndex(int newColorIndex) {
		colorIndex = newColorIndex;
	}
	
	public int getColorIndex() {
		return colorIndex;
	}
	
	public void setMaterial(Material mat) {
		for(int i = 0; i < paintedParts.Length; i++) {
			paintedParts[i].renderer.material = mat;
		}
	}
}
