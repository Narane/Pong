using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour {
	public float speed = 4;
	public KeyCode moveup;
	public KeyCode movedown;
	
	// Update is called once per frame
	void Update () {
		//Following the 'consider storing value in temp var'...
		Vector2 v = rigidbody2D.velocity;

		if (Input.GetKey (moveup)) {
			v.y = speed;
		} else if (Input.GetKey (movedown)) {
			v.y = -speed;
		} else {
			v.y = 0;
		}
		v.x = 0;
		rigidbody2D.velocity = v; 
	}
}
