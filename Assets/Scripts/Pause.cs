using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	public FlyingBirds bird;
	public layerp player;
	public bool paused= false;

	public  void GetPause(){
		
		if (!paused) {
			bird.enabled = false;
			player.enabled = false;
			//FlyingBirds.TurnOff();
			//FlyingBirds.enabled = false;
			paused = true;
		} else {
			bird.enabled = true;
			player.enabled = true;
			//FlyingBirds.TurnOn ();
			//FlyingBirds.enabled = true;
			paused = false;
		}

	}

}
