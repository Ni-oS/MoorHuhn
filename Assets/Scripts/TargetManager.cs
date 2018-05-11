using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour {


	[Header("Bird")]

	public Transform[] walkingTargetResp;
	public Transform[] walkingTargetWayPoints;
	public GameObject walkingTargetPrefab;
	private int Resp;
	private Transform respPosition;

<<<<<<< HEAD
	private int countBirds;
=======
	static int countBirds;
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7

	void Start(){
		countBirds = 0;
		//SetRandom ();
		//StartCoroutine(waitOfInstantiate());
<<<<<<< HEAD
		//InstantiateWalkingTarget ();
=======
		InstantiateWalkingTarget ();
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7

	}
	private void SetRandom(){
		Resp = Random.Range (0, walkingTargetResp.Length);
		respPosition = walkingTargetResp [Resp];
	}


	public void dicsrease(){
<<<<<<< HEAD
		countBirds = countBirds - 1;
		Debug.Log (countBirds);
=======
		countBirds -= 1;
		Debug.Log (countBirds);
		//InstantiateWalkingTarget ();
		//Debug.Log (countBirds);
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7
	}

	public void Update(){

		if(countBirds < 4){
<<<<<<< HEAD

=======
			//Invoke ("InstantiateWalkingTarget", 1.2f);
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7
			InstantiateWalkingTarget ();
			//StartCoroutine(waitOfInstantiate());
			Debug.Log (countBirds);
		}
	}

	public void InstantiateWalkingTarget(){
		SetRandom ();
<<<<<<< HEAD
		GameObject walkingTarget = Instantiate (walkingTargetPrefab,respPosition.position, respPosition.rotation);
		walkingTarget.GetComponent<FlyingBirds>().init (walkingTargetWayPoints);
		countBirds = countBirds + 1;
=======

		GameObject walkingTarget = Instantiate (walkingTargetPrefab, respPosition.position, respPosition.rotation);
		walkingTarget.GetComponent<FlyingBirds>().init (walkingTargetWayPoints);
		countBirds += 1;
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7


	}
	IEnumerator waitOfInstantiate(){
		yield return new WaitForSeconds (1.1f);
		InstantiateWalkingTarget ();

	}
}


