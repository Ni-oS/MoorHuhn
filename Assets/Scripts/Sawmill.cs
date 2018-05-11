using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawmill : MonoBehaviour {
	float x=0.0f;
	Quaternion toRotation;
	Vector3 abc;

	void Start(){
		
		//this.transform.rotation=new Vector3(0, -90, 90);
	}
	// Update is called once per frame
	void Update () {
		abc = new Vector3 (-x, transform.rotation.y, -90);
		toRotation = Quaternion.Euler (abc);

		x=x+0.3f;
		if(x==360.0f)
			x=0.0f;
		//this.transform.rotation = new Vector3 (0,0,0);
		transform.rotation=Quaternion.Slerp(transform.rotation,toRotation,1.0f);
		//GameObject.transform.rotation.x + 1.0f;



	}
}
