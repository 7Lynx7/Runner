using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public int[] Prepyatsviya = new int[5];
    public int z;
    public int targetZ;
    public float[] zPosition = new float[5];
    public float Speed;
    public GameObject Player;
    public float tilt;
    float moveHorizontal;
    float moveVertical = 0;
    public float zMin, zMax;

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

    private void Start()
    {
       // gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        

    }

    private void FixedUpdate()
    {
      
        //transform.position = new Vector3
        // (
        //     transform.position.x,
             
        //     transform.position.y,
        //     Mathf.Clamp(transform.position.z, zMin, zMax)
        // );
        if (Prepyatsviya[z] > 0)
        {
            if (z == 0 || z == 4)
            {
                if (z == 0)
                {
                    targetZ = 1;
                }
                if (z == 4)
                {
                    targetZ = 2;
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
            LeftMove();
        }
        if (targetZ < z)
        {
            RightMove();
        }
        //if (transform.position.z < zPosition[0]) z = 0;
        //if (transform.position.z > zPosition[4]) z = 4;
        //if (transform.position.z >zPosition[0] && transform.position.z < zPosition[1]) z = 1;
        if (z == targetZ) moveHorizontal = 0;
        if (targetZ < z && transform.position.x < zPosition[targetZ])
        {
            z = targetZ;
            moveHorizontal = 0;
        }
        if (targetZ > z && transform.position.x > zPosition[targetZ])
        {
            z = targetZ;
            moveHorizontal = 0;
        } //здесь он заканчиваеться
        time++;
        if (time >= TimeToAttak - 10 /*&& gameObject.GetComponent<MeshRenderer>().material.color == Color.white*/)
         //   gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        if (time >= TimeToAttak)
        {
            time = 0f;
            Attak();
            TimeToAttak = UnityEngine.Random.Range(60, 80);
        }//конец кода отвечающего за атаку

        //движение по физике
        
        
            Vector3 movement = new Vector3(-moveHorizontal, moveVertical, 0.0f);
            GetComponent<Rigidbody>().velocity = movement * Speed;
            GetComponent<Rigidbody>().rotation = Quaternion.Euler(4f , 180f, GetComponent<Rigidbody>().velocity.x * tilt);
        

    }
    public float time; //этот код отвечает за атаку
    public float TimeToAttak;
    public GameObject Bullet;
    public GameObject BlasterSound;
    public void Attak()
    {
        //gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        Instantiate(Bullet, gameObject.transform.position, Quaternion.Euler(-96f, 0, 0f));
        BlasterSound.GetComponent<AudioSource>().Play();
    }
}