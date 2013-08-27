using UnityEngine;
using System.Collections;

public class PlayMusicOnStateChange : MonoBehaviour {
	void OnActivate(bool state) {
		GameObject musicPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
		if(musicPlayer != null) {
			if(state) {
				if(!musicPlayer.audio.isPlaying) {
					musicPlayer.audio.Play();
				}
			} else {
				musicPlayer.audio.Stop();
			}
		}
	}
}

