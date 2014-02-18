using UnityEngine;
using System.Collections;

public class ScoreboardScript : MonoBehaviour {
	public GUISkin ourskin;
	void OnGUI(){
		GUI.skin = ourskin;
		GUI.Label (new Rect (Screen.width / 2 - 150, 20, 100, 100), "" + GameManager.player1Score);
		GUI.Label (new Rect (Screen.width / 2 + 150, 20, 100, 100), "" + GameManager.player2Score);
	}
}
