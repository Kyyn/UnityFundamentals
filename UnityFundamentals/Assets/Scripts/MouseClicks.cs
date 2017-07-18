using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour 
{
    private Color originalColor = Color.white;


    private void Awake()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }
    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    private void OnMouseEnter()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        this.GetComponent<Renderer>().material.color = originalColor;
    }
}
