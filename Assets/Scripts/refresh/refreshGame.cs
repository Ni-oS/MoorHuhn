using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class refreshGame : MonoBehaviour {
	
	public string Load;



	public void Loader(){
		
		SceneManager.LoadScene (Load);

	}
}
