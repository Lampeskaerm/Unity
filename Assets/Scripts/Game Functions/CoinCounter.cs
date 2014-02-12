using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour {
	GameObject player;

	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		int coins = player.GetComponent <PlayerCollisions> ().coins;
		guiText.text = "Coins: " + coins;
	}
}
