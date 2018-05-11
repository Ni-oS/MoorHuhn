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

	private int countBirds;

	void Start(){
		countBirds = 0;
		//SetRandom ();
		//StartCoroutine(waitOfInstantiate());
		//InstantiateWalkingTarget ();

	}
	private void SetRandom(){
		Resp = Random.Range (0, walkingTargetResp.Length);
		respPosition = walkingTargetResp [Resp];
	}


	public void dicsrease(){
		countBirds = countBirds - 1;
		Debug.Log (countBirds);
	}

	public void Update(){

		if(countBirds < 4){

			InstantiateWalkingTarget ();
			//StartCoroutine(waitOfInstantiate());
			Debug.Log (countBirds);
		}
	}

	public void InstantiateWalkingTarget(){
		SetRandom ();
		GameObject walkingTarget = Instantiate (walkingTargetPrefab,respPosition.position, respPosition.rotation);
		walkingTarget.GetComponent<FlyingBirds>().init (walkingTargetWayPoints);
		countBirds = countBirds + 1;


	}
	IEnumerator waitOfInstantiate(){
		yield return new WaitForSeconds (1.1f);
		InstantiateWalkingTarget ();

	}
}


