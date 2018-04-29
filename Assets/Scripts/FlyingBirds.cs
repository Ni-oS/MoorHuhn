using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlyingBirds : MonoBehaviour {
	
	private NavMeshAgent navMesh;
	public GameObject mi;
	private Transform curDestination;
	private Transform[] wayPoints;
	int way;
	//private int health;
	public AudioSource dead;
	private Weapon weapon;


	//public GameObject[] healthImages;
	public GameObject destroyedTargetPrefab;

	public void init(Transform[] _waypoints){
		wayPoints = _waypoints;
	}



	private Transform currentTransform;
	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent> ();
		//health = healthImages.Length;
		currentTransform = this.transform;
		SetRandom ();
	}

	// Update is called once per frame
	void Update () {
		//float dist = navMesh.remainingDistance;
		Transform currentTransform = transform;
		if(mi.transform.position.x < curDestination.transform.position.x){
			mi.transform.position = new Vector3(mi.transform.position.x+1.0f, mi.transform.position.y, mi.transform.position.z);
		}
		if(mi.transform.position.y < curDestination.transform.position.y){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y+1.0f, mi.transform.position.z);
		}
		if(mi.transform.position.z < curDestination.transform.position.z){
			mi.transform.position = new Vector3( mi.transform.position.x, mi.transform.position.y, mi.transform.position.z+1.0f);
		}
		if ( mi.transform.position.z - curDestination.transform.position.z < 0.1f && mi.transform.position.x - curDestination.transform.position.x < 0.1f && mi.transform.position.y - curDestination.transform.position.y < 0.1f) {
			SetRandom ();
		}
	


	}

	private void SetRandom(){
		way = Random.Range (0, wayPoints.Length);
		curDestination = wayPoints [way];
		navMesh.SetDestination (curDestination.position);
	}
	public GameObject man;
	public void TakeDamage(){
		//health--;
		//healthImages [health].SetActive (false);
		//if (health <= 0) {
			//Transform currentTransform = transform;
			//GameObject go = Instantiate (destroyedTargetPrefab, currentTransform.position, currentTransform.rotation);
		man.GetComponent<TargetManager>().dicsrease();
			Destroy (gameObject);
		dead.Play ();
			//Destroy (go, 5.0f);
		//}
	}


}
