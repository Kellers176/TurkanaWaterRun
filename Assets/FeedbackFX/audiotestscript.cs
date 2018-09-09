using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotestscript : MonoBehaviour {

	AudioSource asfx;

	void Start () {
		asfx = gameObject.GetComponent<AudioSource> ();
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			asfx.Play ();
		}
	}
}


// rock interact volume should be 0.75
//water pour is fine at 1
//on move is fine at 1
//jug should be at around 0.4
