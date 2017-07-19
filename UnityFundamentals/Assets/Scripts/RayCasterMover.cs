using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterMover : MonoBehaviour
{
    public Camera _camera;
    private Ray ray;
    private RaycastHit hit;
    private GameObject hitObject = null;
    private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
        {
            ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast (ray, out hit))
            {
                if (hit.collider.name == "Cube")
                {
                    hitObject = hit.collider.gameObject;
                    offset = hitObject.transform.position - hit.point;
                }
            }
        }

        if (hitObject)
        {
            if (Input.GetMouseButton(0))
            {
                ray = _camera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast (ray, out hit))
                {
                    hitObject.transform.position = new Vector3(hit.point.x + offset.x, hitObject.transform.position.y, hit.point.z + offset.z);
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                hitObject = null;
            }
        }
	}
}
