using UnityEngine;
using System.Collections;

public class GUITimer : MonoBehaviour {
	private float timer = 0.0f;
	public static int min = 0, sec = 0;
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timerCalc ();
		if (min == 0) {
			guiText.text = "" + sec;
		} else {
			guiText.text = min + "." + sec;
		}
	}

	void timerCalc () {
		min = Mathf.RoundToInt(timer / 60);
		sec = Mathf.RoundToInt(timer % 60);
	}
}
