using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {
	public int coins = 0;
	public bool maxCoinsReached;

	void Update() {
		int maxCoins = GameObject.FindGameObjectsWithTag("Coin").Length;

		if (maxCoins == coins) {
			maxCoinsReached = true;
		}
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Coin") {
			AddScore();
			Destroy(col.gameObject);
		}
	}



	public int AddScore(){
		return coins += 1;
	}
}
