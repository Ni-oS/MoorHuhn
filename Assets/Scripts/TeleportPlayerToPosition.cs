using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayerToPosition : MonoBehaviour
{
    public void Teleport()
    {
        Player.SetPosition(transform.position);
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
