using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateScript : MonoBehaviour
{
    public float moveSpeed = 20f;

    public float rotationSpeed;
    // Update is called once per frame
    void Update () 
    {	
        //Moving the viewpoint
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*moveSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right*moveSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up*moveSpeed*Time.deltaTime);
        }	
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down*moveSpeed*Time.deltaTime);
        }
		
    }
}