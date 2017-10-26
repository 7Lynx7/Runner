using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float Speed;
    public float xMin, xMax, yMin, yMax;
    public float tilt;
    public bool Controlled;
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3
         (
             Mathf.Clamp(transform.position.x, xMin, xMax),
             Mathf.Clamp(transform.position.y, yMin, yMax),
             //Mathf.Clamp(transform.position.z, zMin, zMax),
             transform.position.z
         );
        if (transform.position.x > xMax || transform.position.x < xMin || transform.position.y > yMax || transform.position.y < yMin /*|| transform.position.z > zMax || transform.position.z < zMin*/)
        {
            GetComponent<Rigidbody>().velocity = new Vector3();
        }
        //  GetComponent<Rigidbody>().position = new Vector3
        //(
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.x, xMin, xMax),
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.y, yMin, yMax),
        //    Mathf.Clamp(GetComponent<Rigidbody>().position.z, zMin, zMax)
        //);

        /* if (Input.GetKey(KeyCode.W) && transform.position.x > TopGranX && transform.position.y < TopGranY)
         {
             transform.Translate(Vector3.forward * Speed * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.S) && transform.position.x < BotGranX && transform.position.y > BotGranY)
         {
             transform.Translate(Vector3.back * Speed * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.A) && transform.position.z < LeftGran)
         {
             transform.Translate(Vector3.down * Speed * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.D) && transform.position.z > RightGran)
         {
             transform.Translate(Vector3.up * Speed * Time.deltaTime);
         }*/
    }

    float moveVertical;
    private void FixedUpdate()
    {
        
            if (Input.GetAxis("Vertical") > 0)
            {
                moveVertical = 1;
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                moveVertical = -1;
            }
            //Input.GetAxis("Vertical");

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Input.GetAxis("Vertical");
        if (Controlled)
        {
            Vector3 movement = new Vector3(-moveHorizontal, moveVertical / 2, 0.0f);
            GetComponent<Rigidbody>().velocity = movement * Speed;
            GetComponent<Rigidbody>().rotation = Quaternion.Euler(5f, 180f, GetComponent<Rigidbody>().velocity.x * tilt);
        }
    }
}
