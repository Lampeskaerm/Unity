using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {
	bool isJumping;
	MovementVars movements = new MovementVars ();
	float moveSpeed;
	float jumpSpeed = 400f;
	bool rightKeyPressed;
	bool leftKeyPressed;
	bool spacePressed;
	
	// Update is called once per frame
	void Update () {
		moveSpeed = movements.MoveSpeed;

		rightKeyPressed = Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKey (KeyCode.RightArrow);
		leftKeyPressed = Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKey (KeyCode.LeftArrow);
		spacePressed = Input.GetKeyDown (KeyCode.Space);
		
		if ( rightKeyPressed ) {
			
			transform.Translate(new Vector2(moveSpeed,0) * Time.deltaTime);

			if( spacePressed && !isJumping ) {
					rigidbody2D.AddForce(Vector2.up * jumpSpeed);
			}
			
		} else if( leftKeyPressed ) {
			
			transform.Translate(new Vector2(-moveSpeed,0) * Time.deltaTime);

			if( spacePressed && !isJumping ) {
				rigidbody2D.AddForce(Vector2.up * jumpSpeed);
			}
			
		} else if( spacePressed && !isJumping) {
			
			rigidbody2D.AddForce(Vector2.up * jumpSpeed);
			
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Ground"){
			isJumping = false;
		}
	}
	
	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.tag == "Ground"){
			isJumping = true;
		}
	}


}
