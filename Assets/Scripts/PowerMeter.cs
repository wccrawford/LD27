using UnityEngine;
using System.Collections;

public class PowerMeter : MonoBehaviour {
	/*public GameObject[] levels;
	public Material[] levelMaterials;
	public Material offMaterial;*/
	
	public string[] levels;
	
	//public UIAtlas meterAtlas;
	
	private UISprite meterSprite;
	
	private int level;
	
	// Use this for initialization
	void Start () {
		meterSprite = GetComponent<UISprite>();
		setLevel(level);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void setLevel(int newLevel) {
		level = Mathf.Clamp(newLevel, 0, levels.Length);
		meterSprite.spriteName = levels[level];
		/*for(int i = 0; i < levels.Length; i++) {
			if(i > level - 1) {
				levels[i].renderer.material = offMaterial;
			} else {
				levels[i].renderer.material = levelMaterials[i];
			}
		}*/
	}
	
	public void OnGameOver() {
		gameObject.SetActive(false);
		enabled = false;
	}
}
