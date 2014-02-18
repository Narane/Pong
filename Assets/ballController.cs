using UnityEngine;
using System.Collections;

public class ballController : MonoBehaviour {
	public Transform ball;
	public Camera camMain;

	// Use this for initialization
	void Start () {
		StartBall ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collided){
		if (collided.collider.tag == "Player") {
			Vector2 v = rigidbody2D.velocity;
			if (collided.rigidbody.velocity.y != 0){
				v.y = (v.y / 2) + collided.rigidbody.velocity.y / 3;
			}
			v.x = v.x * 1.05f;

			rigidbody2D.velocity = v;
		}
	}

	void StartBall(){
		float rng = Random.Range (-1f, 1f);
		int rngy = Random.Range (-1, 1);
		if (rngy != -1) {
			rngy = 1;
		}

		Debug.Log (rng);
		if (rng >= 0) {
			rigidbody2D.AddForce ( new Vector2(15, 20*rngy));
		} else {
			rigidbody2D.AddForce ( new Vector2(-15, 20*rngy));
		}
	}

	void ResetBall(){
		StartCoroutine ("Wait");
		float rng = Random.Range (0, 20);
		Vector3 posBall = ball.position;
		posBall.x = 0f;
		posBall.y = (rng / 10) - 1;
		ball.position = posBall;

		Vector2 v = new Vector2 (0f, 0f);
		rigidbody2D.velocity = v;
		StartBall ();
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds (3);
	}
}
