using UnityEngine;
using System.Collections;

public class FinishTrigger : MonoBehaviour {
	GameObject player;
	bool maxCoins;
	public static int min, sec;

	void OnTriggerEnter2D(Collider2D col) {
		player = GameObject.FindGameObjectWithTag ("Player");
		maxCoins = player.GetComponent<PlayerCollisions>().maxCoinsReached;

		if (col.gameObject.tag == "Player" && maxCoins == true) {
			min = GUITimer.min;
			sec = GUITimer.sec;
			Application.LoadLevel("LevelComplete");
		}
	}
}
