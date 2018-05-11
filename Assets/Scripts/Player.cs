using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;
<<<<<<< HEAD
	private int health;
    private void Start()
    {
		health = 5;
        instance = this;

    }
	private void Update(){
		if (health <= 0) {
			Destroy (instance);
		}
	}
=======

    private void Start()
    {
		
        instance = this;

    }

>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7
    public static Vector3 GetPosition()
    {
        return instance.transform.position;
    }

    public static void SetPosition(Vector3 targetPosition)
    {
        instance.transform.position = new Vector3(targetPosition.x, instance.transform.position.y, targetPosition.z);
    }
<<<<<<< HEAD
	public static void TakeDamage(){
		instance.health--;
	}
=======
>>>>>>> 27b1c8ef54964eab18e9575cdbc8851b624af1d7
}
