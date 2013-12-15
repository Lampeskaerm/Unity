using UnityEngine;
using System.Collections;

public class TriggerEvent : MonoBehaviour {
	GameObject player;
	bool maxCoins;

	void OnTriggerEnter2D(Collider2D col) {
		player = GameObject.FindGameObjectWithTag ("Player");
		maxCoins = player.GetComponent<PlayerCollisions>().maxCoinsReached;

		if (col.gameObject.tag == "Player" && maxCoins == true) {
			Debug.Log("FINISH!!!!");
		}
	}
}
