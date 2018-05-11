using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EGG : MonoBehaviour {

	public GameObject mi;
	public Player player;
	private Transform curDestination;
	private Weapon weapon;

	// Use this for initialization
	void Start () {
		curDestination = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(mi.transform.position.x < curDestination.transform.position.x){
			mi.transform.position = new Vector3(mi.transform.position.x+1.0f, mi.transform.position.y, mi.transform.position.z);
		}
		if(mi.transform.position.y < curDestination.transform.position.y){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y+1.0f, mi.transform.position.z);
		}
		if(mi.transform.position.z < curDestination.transform.position.z){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y, mi.transform.position.z+1.0f);
		}
		if(mi.transform.position.x > curDestination.transform.position.x){
			mi.transform.position = new Vector3(mi.transform.position.x-1.0f, mi.transform.position.y, mi.transform.position.z);
		}
		if(mi.transform.position.y > curDestination.transform.position.y){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y-1.0f, mi.transform.position.z);
		}
		if(mi.transform.position.z > curDestination.transform.position.z){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y, mi.transform.position.z-1.0f);
		}
		if((mi.transform.position.z - curDestination.transform.position.z < 0.1f && mi.transform.position.z - curDestination.transform.position.z > -0.1f) && (mi.transform.position.x - curDestination.transform.position.x < 0.1f && mi.transform.position.x - curDestination.transform.position.x > -0.1f) && (mi.transform.position.y - curDestination.transform.position.y < 0.1f && mi.transform.position.y - curDestination.transform.position.y > -0.1f)) {
			Player.TakeDamage ();
			TakeDamage ();
		}
	}

	public GameObject man;
	public void TakeDamage(){
		Parent.NewEgg();
		Destroy (gameObject);
	}
}
