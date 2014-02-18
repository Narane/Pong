using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D collided){
		if (collided.transform.name == "ball") {
			string wallName = transform.name;
			GameManager.Score (wallName);
			if (wallName == "wallRight" || wallName == "wallLeft") {
				collided.gameObject.SendMessage("ResetBall");
			}
		}
	}
}
