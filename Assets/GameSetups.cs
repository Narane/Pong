using UnityEngine;
using System.Collections;

public class GameSetups : MonoBehaviour {
	public Camera camMain;

	public BoxCollider2D wallTop;
	public BoxCollider2D wallBottom;
	public BoxCollider2D wallLeft;
	public BoxCollider2D wallRight;

	public Transform player1;
	public Transform player2;
	
	// Update is called once per frame
	void Update () {
				//--------BOUNDING BOX CODE--------------//
				// ScreenToWorldPoint makes sure that the bounding width is tied to the main
				//  camera instead of whatever the game's perspective makes out to be pixel-wise
				float sizeX = camMain.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x;
				float sizeY = camMain.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y;
				float posTopY = camMain.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f;
				float posBotY = camMain.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f;
				float posLeftX = camMain.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.5f;
				float posRightX = camMain.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x + 0.5f;
				wallTop.size = new Vector2 (sizeX, 1f);
				wallTop.center = new Vector2 (0f, posTopY);
				wallBottom.size = new Vector2 (sizeX, 1f);
				wallBottom.center = new Vector2 (0f, posBotY);
				wallLeft.size = new Vector2 (1f, sizeY);
				wallLeft.center = new Vector2 (posLeftX, 0f);
				wallRight.size = new Vector2 (1f, sizeY);
				wallRight.center = new Vector2 (posRightX, 0f);
				//--------END BOUNDING BOX CODE--------------//

				Vector3 posPlayer1 = player1.position;
				posPlayer1.x = camMain.ScreenToWorldPoint (new Vector3 (35f, 0f, 0f)).x;
				Vector3 posPlayer2 = player2.position;
				posPlayer2.x = camMain.ScreenToWorldPoint (new Vector3 (Screen.width - 35f, 0f, 0f)).x;
				player1.position = posPlayer1;
				player2.position = posPlayer2;
		}
}
