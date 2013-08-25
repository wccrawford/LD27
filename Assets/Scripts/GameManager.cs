using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float timeLimit = 10f;
	
	public string highScoreKey;
	
	public UILabel timeLeftLabel;
	public UILabel highScoreLabel;
	public UILabel scoreLabel;
	
	public GameObject[] notifyGameOver;
	
	private float timeRemaining = 0f;
	
	private int score = 0;
	
	// Use this for initialization
	void Start () {
		timeRemaining = timeLimit;
		setHighScore(getHighScore());
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
		
		if(score > getHighScore()) {
			setHighScore(score);
		}
	}
	
	public int getHighScore() {
		if(PlayerPrefs.HasKey(highScoreKey)) {
			return PlayerPrefs.GetInt(highScoreKey);
		}
		
		return 0;
	}
	
	public void setHighScore(int score) {
		PlayerPrefs.SetInt(highScoreKey, score);
		
		highScoreLabel.text = "High Score: " + score.ToString();
	}
}

