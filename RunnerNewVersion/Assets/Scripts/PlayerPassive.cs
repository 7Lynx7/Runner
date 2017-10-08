using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPassive : MonoBehaviour {

    public int[] Prepyatsviya = { 0, 0, 0 };
    public int z;
    public int targetZ;
    public float[] zPosition = new float[3];
    public float Speed;
 

    public bool IsMove = false;
    public float tilt;
    float moveHorizontal;
    float moveVertical = 0;

    public void LeftMove()
    {
        moveHorizontal = -1;
        // transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
    public void RightMove()
    {
        moveHorizontal = 1;
        // transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }

  

    private void FixedUpdate()
    {
        if (Prepyatsviya[z] > 0)
        {

            if (z == 0 || z == 2)
            {
                if (z == 0)
                {
                    targetZ = 1;
                    
                }
                if (z == 2)
                {
                    targetZ = 1;
                    
                }
            }
            else
            {
                if (Prepyatsviya[z - 1] > Prepyatsviya[z + 1])
                {
                    targetZ = z + 1;
                   
                }
                if (Prepyatsviya[z - 1] == Prepyatsviya[z + 1])
                {
                    targetZ = z - 1;
                   
                }
                if (Prepyatsviya[z - 1] < Prepyatsviya[z + 1])
                {
                    targetZ = z - 1;
                   
                }
            }

        } //здесь начинаеться код который двигает врага от препятствий
        if (targetZ > z)
        {
            IsMove = true;
            LeftMove();
        }
        if (targetZ < z)
        {
            IsMove = true;
            RightMove();
        }
        if (targetZ < z && transform.position.z < zPosition[targetZ])
        {
            z = targetZ;
            IsMove = false;
            moveHorizontal = 0;
        }
        if (targetZ > z && transform.position.z > zPosition[targetZ])
        {
            z = targetZ;
            IsMove = false;
            moveHorizontal = 0;
        } //здесь он заканчиваеться

        Vector3 movement = new Vector3(0.0f, moveVertical, -moveHorizontal);
        GetComponent<Rigidbody>().velocity = movement * Speed;
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.z * tilt - 90f, 0f, 0.0f);



    }
	

	
}
