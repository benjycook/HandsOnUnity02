using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// convert mouse position into world coordinates
		Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		// get direction you want to point at
		Vector2 direction = (mouseWorldPosition - (Vector2) transform.position).normalized;

		// set vector of transform directly
		// We're using right, because remember in the sprite editor?
		// We set the pivot to the left side, meaning that for the cannon,
		// right means "forward"
		transform.right = direction;
	}
}
