using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {

	float moveSpeed = 5f;
	float jumpSpeed = 80f;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(new Vector2(moveSpeed,0) * Time.deltaTime);
		} else if(Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector2(-moveSpeed,0) * Time.deltaTime);
		} else if(Input.GetKeyDown (KeyCode.Space)) {
			transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime, Space.World);
		}
	}
}
