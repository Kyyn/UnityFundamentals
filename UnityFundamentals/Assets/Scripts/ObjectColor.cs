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
            EnableColor();
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            DisableColor();
        }
	}

    public void EnableColor()
    {
        GetComponent<Renderer>().material.color = changedColor;
    }

    public void DisableColor()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }
}
