using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCanvas : MonoBehaviour {
	public layerp layer;
	public GameObject[] Array=new GameObject[6];

	void Update(){
		switch (layer.ShootCount) {
		case(6):
			Array [0].SetActive (false);
			break;
		case(5):
			Array [1].SetActive (false);
			break;
		case(4):
			Array [2].SetActive (false);
			break;
		case(3):
			Array [3].SetActive (false);
			break;
		case(2):
			Array [4].SetActive (false);
			break;
		case(1):
			Array [5].SetActive (false);
			break;
		case(0):
			Array [6].SetActive (false);
			break;
		}
		/*for(int i = 0; i<=6; i++){
			if (layerp.ShootCount<i) {

			}*/


	}
}
