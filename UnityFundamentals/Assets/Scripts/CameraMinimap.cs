﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMinimap : MonoBehaviour
{
    public Transform target = null;
    public bool followTarget = true;
    public float cameraHeight = 18.0f;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{

	}

    private void LateUpdate()
    {
        if (target)
        {
            if (followTarget)
            {
                this.transform.position = new Vector3(target.transform.position.x, cameraHeight, target.transform.position.z);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x, cameraHeight, this.transform.position.z);
            }
        }
    }
}
