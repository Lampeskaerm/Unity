using UnityEngine;
using System.Collections;

public class SceneMovements : MonoBehaviour {
	GameObject player;
	float playerPosX, playerPosY;
	MovementVars movements = new MovementVars();

	// Use this for initialization
	void Start () {
		Debug.Log (transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerPosX = player.transform.position.x;
		playerPosY = player.transform.position.y;
		checkIfHittingSides ();
		checkIfHittingTop ();
	}

	void checkIfHittingSides(){
		if (playerPosX >= transform.position.x + 3) {
			transform.Translate(new Vector2(movements.MoveSpeed, 0) * Time.deltaTime);
		} else if (playerPosX <= transform.position.x - 6){
			transform.Translate(new Vector2(-movements.MoveSpeed, 0) * Time.deltaTime);
		}
	}

	void checkIfHittingTop(){
		if (playerPosY >= transform.position.y + 1.5) {
			Debug.Log("Thing happening");
			transform.Translate(new Vector2(0, movements.MoveSpeed) * Time.deltaTime);
		} else if (playerPosY <= transform.position.y - 1){
			transform.Translate(new Vector2(0, -movements.MoveSpeed) * Time.deltaTime);
		}
	}
}
