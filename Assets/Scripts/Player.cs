using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;

    private void Start()
    {
		
        instance = this;

    }

    public static Vector3 GetPosition()
    {
        return instance.transform.position;
    }

    public static void SetPosition(Vector3 targetPosition)
    {
        instance.transform.position = new Vector3(targetPosition.x, instance.transform.position.y, targetPosition.z);
    }
}
