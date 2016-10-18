using UnityEngine;
using System.Collections;

public class TileHit : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// On any collider started to overlap us
	void OnCollisionEnter2D() {
		// if the collider is the ball
		//if (other.name=="Ball") {
			// trigger our hit animation
		animator.SetTrigger("hit");
		//}
	}
}
