using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// On any collider started to overlap us
	void OnTriggerEnter2D(Collider2D other) {
		// if the collider is the ball
		if (other.name=="Ball") {
			// destroy ourselves
			Destroy (gameObject);
		}
	}
}
