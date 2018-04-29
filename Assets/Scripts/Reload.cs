using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {
	public layerp player;
	public BulletCanvas bullets;
	public void Reloading(){
		player.ShootCount = 7;
		for(int i=0;i<=6;i++){
			bullets.Array [i].SetActive (true);
		}
	}
}
