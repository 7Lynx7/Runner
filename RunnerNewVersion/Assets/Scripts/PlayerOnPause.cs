using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnPause : MonoBehaviour {
    float tilt = 1;
    public float xMin, xMax, yMin, yMax, zMin, zMax;
    private void FixedUpdate()
    {
        transform.position = new Vector3
       (
           transform.position.x,
           //Mathf.Clamp(transform.position.x, xMin, xMax),
           Mathf.Clamp(transform.position.y, yMin, yMax),
           Mathf.Clamp(transform.position.z, zMin, zMax)
       );
        if (transform.position.x > xMax || transform.position.x < xMin || transform.position.y > yMax || transform.position.y < yMin || transform.position.z > zMax || transform.position.z < zMin)
        {
            GetComponent<Rigidbody>().velocity = new Vector3();
        }

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.z * tilt - 90f, 0.0f, 0.0f);

    }
}
