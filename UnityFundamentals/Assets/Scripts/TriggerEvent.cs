using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour 
{
    public GameObject lightBulb = null;
    public GameObject wall = null;
    public AudioClip lightBulbOn = null;

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
            lightBulb.SetActive(true);
            GetComponent<AudioSource>().clip = lightBulbOn;
            GetComponent<AudioSource>().Play();
            wall.GetComponent<ObjectScaling>().EnableScale();
            wall.GetComponent<ObjectColor>().EnableColor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            lightBulb.SetActive(false);
            GetComponent<AudioSource>().clip = lightBulbOn;
            GetComponent<AudioSource>().Stop();
            wall.GetComponent<ObjectScaling>().DisableScale();
            wall.GetComponent<ObjectColor>().DisableColor();
        }
    }
}
