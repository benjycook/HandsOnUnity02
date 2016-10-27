using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// The position at the end of the cannon
	public Transform barrelPosition;

	// Have we been fired from the cannon yet?
	private bool hasBeenFired = false;

	// variable to store my rigid body component
	private Rigidbody2D myRigidBody;

	public Transform restartLine;

	// how much power is the shot?
	public int shootPower = 1000;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		// If we haven't been shot out of the cannon
		if (hasBeenFired == false) {
			// then set our position to be the barrel at the end of the cannon
			transform.position = barrelPosition.position;
		}
		// If the mouse has been clicked and we haven't been fired yet
		if (Input.GetMouseButtonDown(0) && hasBeenFired == false) {
			// remember that we've been shot out
			hasBeenFired = true;

			// convert mouse position into world coordinates
			Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			// get direction you want to point at
			Vector2 direction = ( mouseWorldPosition - (Vector2) transform.position).normalized;

			// using our rigid body component,
			// let's add a force in the direction we want
			// which is towards the mouse
			// and the strength of the force (the magnitude of the vector)
			// is our variable shootPower
			myRigidBody.AddForce(direction*shootPower);
		}

		if (transform.position.y < restartLine.position.y) {
			
			myRigidBody.velocity = Vector2.zero;
			hasBeenFired = false;

		}
	}
}
