﻿using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
	private int colorIndex;
	
	public void setColorIndex(int newColorIndex) {
		colorIndex = newColorIndex;
	}
	
	public int getColorIndex() {
		return colorIndex;
	}
}