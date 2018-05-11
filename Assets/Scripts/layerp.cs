using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerp : MonoBehaviour {
	 
	public Transform playerHad;
	public float rayLength=10;

	private WaitForSeconds lineRenderTime;
	public int ShootCount=7;
	public Weapon weapon;
	 


	private float timer=0.0f;

	public void Start(){
		
		weapon.init ();
		lineRenderTime = new WaitForSeconds (weapon.fireRate * 0.38f);

	}
	private void raycast(){
		StartCoroutine (waitBeforeShoot ());
	}
	private void makeShot(Rigidbody rb,RaycastHit hit){
		weapon.Shoot (hit.point,-hit.normal,rb);
		Invoke ("soundReload",1.2f);
		timer = 0.0f;
		//StartCoroutine (lineRenderer ());
	}
	private void MakeWalkingTargetShot(GameObject TargetGo,RaycastHit hit){
		weapon.ShootWalkingTarget (hit.point, - hit.normal, TargetGo);
		Invoke ("soundReload",1.2f);
		timer = 0;
		//StartCoroutine (lineRenderer ());
	}
	void Update () {
		raycast ();

		timer = timer + Time.deltaTime;
	}

	/*private IEnumerator lineRenderer(){
		yield return lineRenderTime;
		weapon.clearShootTrace ();
	}*/
	public void soundReload(){
		weapon.reload.Play ();
	}


	IEnumerator waitBeforeShoot(){
		
		Ray ray = new Ray (playerHad.position,playerHad.forward);

		RaycastHit hit;
		yield return new WaitForSeconds (0.3f);
		//Debug.DrawRay (playerHad.position, playerHad.forward*rayLength,Color.green,0.1f);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.gameObject.CompareTag ("Target") && timer >= weapon.fireRate) {
				
				if(ShootCount != 0){
					
				//makeShot (hit.collider.GetComponent<Rigidbody> (), hit);	
					MakeWalkingTargetShot (hit.collider.gameObject, hit);
				ShootCount = ShootCount - 1;


			}else{
					weapon.empty.Play ();
				}
			}  
		}
	}


}