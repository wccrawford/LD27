using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float timeLimit = 10f;
	
	public UILabel timeLeftLabel;
	public UILabel scoreLabel;
	
	public GameObject[] notifyGameOver;
	
	private float timeRemaining = 0f;
	
	private int score = 0;
	
	// Use this for initialization
	void Start () {
		timeRemaining = timeLimit;
	}
	
	// Update is called once per frame
	void Update () {
		if(timeRemaining <= 0f) {
			timeRemaining = 0f;
			timeLeftLabel.text = "Time's up!";
		} else {
			timeRemaining -= Time.deltaTime;
			
			timeLeftLabel.text = Mathf.CeilToInt(timeRemaining).ToString();
			
			if(timeRemaining <= 0f) {
				for(int i = 0; i < notifyGameOver.Length; i++) {
					notifyGameOver[i].SendMessage("OnGameOver", SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
	
	public void addScore(int newScore) {
		setScore(score + newScore);
	}
	
	public void setScore(int newScore) {
		score = newScore;
		
		scoreLabel.text = "Score: " + score.ToString();
	}
}

