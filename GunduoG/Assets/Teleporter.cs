using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportCamera;
    public Transform teleportTarget;
    public GameObject thePlayer;
    public Camera miniMap;

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        miniMap.transform.position = teleportCamera.transform.position;
    }
}
