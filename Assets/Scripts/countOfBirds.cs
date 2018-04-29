using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class countOfBirds {

	public int countBirds = 0;

	public int CountBirds{
		get {return countBirds;}
		set {countBirds = value;}
	}

	public void decreas2e(){
		CountBirds = CountBirds - 1;
	}

}
