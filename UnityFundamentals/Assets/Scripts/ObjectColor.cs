using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColor : MonoBehaviour 
{

    public Color changedColor = Color.white;
    private Color originalColor = Color.white;

    private void Awake()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }
    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = changedColor;
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = originalColor;
        }
	}
}
