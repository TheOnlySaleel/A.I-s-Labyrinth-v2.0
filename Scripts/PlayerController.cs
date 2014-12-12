using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public int speed; //Change speed in Inspector

	// Using FixedUpdate over Update for Physics calculations
	void FixedUpdate () {
				float moveHorizontal = Input.GetAxis ("Horizontal");
				float moveVertical = Input.GetAxis ("Vertical");
				//Player only moves on two axes.
				Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
				//Multiplying by time makes speed independent of framerate.
				rigidbody.velocity = movement * Time.deltaTime * speed;
		}
}
