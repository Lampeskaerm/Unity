using UnityEngine;
using System.Collections;

public class FinishGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.text = "Level Complete! You did it in: " + FinishTrigger.min + "." + FinishTrigger.sec + "!";
	}
}
