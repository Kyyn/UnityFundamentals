﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour
{
    public Cameras cameras;
    public Cameras.CameraState cameraState;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            cameras.cameraState = cameraState;
        }
    }
}
