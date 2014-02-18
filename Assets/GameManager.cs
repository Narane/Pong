using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static int player1Score = 0;
	public static int player2Score = 0;
	public Transform ball;

	public static void Score (string wallName){
		if (wallName == "wallRight") {
			player1Score += 1;
		} else if (wallName == "wallLeft") {
			player2Score += 1;
		}
	}
}
