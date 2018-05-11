using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon {
	public float fireRate = 0.1f;
	public float shootForce = 1000f;
	public Transform gunEnd;
	public AudioSource Shooting;
	public AudioSource reload;
	public AudioSource empty;
	public LineRenderer line;

	public bool died = false;

	public void init(){
		line.positionCount = 2;
	}

	public void Shoot(Vector3 shootPoint,Vector3 force,Rigidbody rb){
		line.enabled = true;
		//line.SetPosition (0, gunEnd.position);
		//line.SetPosition (1, shootPoint);

			rb.AddForceAtPosition (force * shootForce, shootPoint);
			Shooting.Play ();
		died = true;

	}
	public void clearShootTrace(){
		line.enabled = false;
	}

	public void ShootWalkingTarget(Vector3 ShootPoint,Vector3 force,GameObject TargetGo){
		line.enabled = true;
		//line.SetPosition (0, gunEnd.position);
		//line.SetPosition (1, ShootPoint);

		TargetGo.GetComponent<FlyingBirds> ().TakeDamage ();

		Shooting.Play ();
	}

	public void ShootEgg(Vector3 ShootPoint,Vector3 force,GameObject TargetGo){
		line.enabled = true;
		//line.SetPosition (0, gunEnd.position);
		//line.SetPosition (1, ShootPoint);

		TargetGo.GetComponent<EGG> ().TakeDamage ();

		Shooting.Play ();
	}

}
