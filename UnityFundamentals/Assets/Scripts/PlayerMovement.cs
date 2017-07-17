using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

    public float moveSpeed = 5.0f;
    public float rotateSpeed = 80.0f;
    public bool canMoveSideways = false;


    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Movement();

    }


    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Key Up Arrow Pressed.");

            this.transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Key Down Arrow Pressed.");
            this.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (canMoveSideways)
            {
                Debug.Log("Key Left Arrow Pressed.");

                this.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
            }
            else
            {
                Debug.Log("Key Left Arrow Pressed: Rotate");

                this.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (canMoveSideways)
            {
                Debug.Log("Key Right Arrow Pressed.");

                this.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            }
            else
            {
                Debug.Log("Key Left Arrow Pressed: Rotate");

                this.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
            }
        }



        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Key W Pressed.");

            this.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Key S Pressed.");
            this.transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
        }
    }
}
