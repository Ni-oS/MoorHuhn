using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsTarget : MonoBehaviour {

	public float maxSpeed=10;
	//public AudioSource audio;



	Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
	void OnCollisionEnter(){
		float ClampedVoluemValue = 1 - Mathf.Clamp01 ((maxSpeed-rb.velocity.sqrMagnitude)/maxSpeed);
		//audio.volume = ClampedVoluemValue;
		//audio.Play ();
	}
}
