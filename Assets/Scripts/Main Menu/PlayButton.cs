using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("Level1");
		}
	}
}
