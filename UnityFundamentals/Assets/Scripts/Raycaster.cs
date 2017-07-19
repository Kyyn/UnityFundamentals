using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour 
{
    public Camera _camera;
    public GameObject obj;
    public Transform origin;
    public float rayLenght = 2.0f;

    private Ray ray;
    private RaycastHit hit;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
        {
            //ray = _camera.ScreenPointToRay(Input.mousePosition);
            /*if (Physics.Raycast(ray))
            {
                Debug.Log("Hit Something.");
            }

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider)
                {
                    Debug.Log("Hit object named: " + hit.collider.name);
                    Instantiate(obj, hit.point, hit.transform.rotation);
                }
            }

            RaycastHit[] hits = null;
            hits = Physics.RaycastAll(ray);

            if (hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    RaycastHit _hit = hits[i];
                    Debug.Log("Hit: " + _hit.collider.name);
                }
            }
            */
            RaycastHit[] hits = null;
            hits = Physics.RaycastAll(origin.position, Vector3.forward, rayLenght );
            if (hits.Length > 0)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    if (hits[i].collider)
                    {
                        Debug.Log("Hit: " + hits[i].collider.name);
                    }
                    
                }
            }
            Debug.DrawRay(origin.position, Vector3.forward * rayLenght, Color.green, 3.0f);
        }
        //Debug.DrawRay(origin.position, Vector3.forward * rayLenght, Color.green, 3.0f);
        //Debug.DrawLine(ray.origin, hit.point, Color.red);
	}
}
