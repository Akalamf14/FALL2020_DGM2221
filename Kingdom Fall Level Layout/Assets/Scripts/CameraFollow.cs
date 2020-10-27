﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight, cameraDistance;

    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.z += cameraHeight;
        pos.y += cameraDistance;
        transform.position = pos;
    }
}
