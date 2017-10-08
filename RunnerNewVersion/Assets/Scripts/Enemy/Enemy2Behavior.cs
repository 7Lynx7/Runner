﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Behavior : MonoBehaviour {

    public int[] Prepyatsviya = new int[5];
    public int z;
    public int targetZ;
    public float[] zPosition = new float [5] ;
    public float Speed;
    public GameObject Player;
    public GameObject Enemy1;
    public bool IsMove = false;
    public float tilt;
    float moveHorizontal;
    float moveVertical = 0;
    public GameObject Bullet;

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
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        
    }

    private void FixedUpdate()
    {
        if (Prepyatsviya[z] > 0)
        {
          
            if (z == 0 || z == 4)
            {
                if (z == 0)
                {
                    targetZ = 2;
                    Speed = 1.71f;
                }
                if (z == 4)
                {
                    targetZ = 2;
                    Speed = 1.71f;
                }
            }
            else
            {
                if (Prepyatsviya[z - 1] > Prepyatsviya[z + 1])
                {
                    targetZ = z + 1;
                    Speed = 1.71f;
                }
                if (Prepyatsviya[z - 1] == Prepyatsviya[z + 1])
                {
                    targetZ = z - 1;
                    Speed = 1.71f;
                }
                if (Prepyatsviya[z - 1] < Prepyatsviya[z + 1])
                {
                    targetZ = z - 1;
                    Speed = 1.71f;
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
        time++;
        if (time >= TimeToAttak - 10 && gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        if (time >= TimeToAttak)
        {
            time = 0f;
            if (Enemy1.GetComponent<EnemyBehavior>().targetZ == targetZ)
            {
                Sdvig();
                TimeToAttak2++;
                if (TimeToAttak2 > 1)
                {
                    Attak();
                }
            }
            else Attak();
            TimeToAttak = UnityEngine.Random.Range(40, 60);
        }//конец кода отвечающего за атаку
       
       //движение по физике
           
            Vector3 movement = new Vector3(0.0f, moveVertical, -moveHorizontal);
            GetComponent<Rigidbody>().velocity = movement * Speed;
            GetComponent<Rigidbody>().rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.z * tilt - 90f, 0.0f, 0.0f);

       
    }
    public float time; //этот код отвечает за атаку
    public float TimeToAttak;
    public float TimeToAttak2;
    public bool AttakTumbler;
    public void Attak()
    {
        if (AttakTumbler)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            Instantiate(Bullet, gameObject.transform.position, Bullet.transform.rotation);
            TimeToAttak2 = 0;
        }
    }
    public void Sdvig()
    {
        if (z == 0 && z == 4)
        {
            if (z == 0) if (Prepyatsviya[1] == 0 && Enemy1.GetComponent<EnemyBehavior>().targetZ !=1)
                {
                    targetZ =  1;
                    AttakTumbler = true;
                    Speed = 5;
                }
            if (z == 4) if (Prepyatsviya[3] == 0 && Enemy1.GetComponent<EnemyBehavior>().targetZ !=3)
                {
                    targetZ = 3;
                    AttakTumbler = true;
                    Speed = 5;
                }
        }
        else
        {
            if (z != 4) if (Prepyatsviya[z + 1] == 0 && Enemy1.GetComponent<EnemyBehavior>().targetZ != z + 1)
            {
                targetZ = z + 1;
                AttakTumbler = true;
                Speed = 5;
            }
            if(z != 0) if (Prepyatsviya[z - 1] == 0 && Enemy1.GetComponent<EnemyBehavior>().targetZ != z - 1)
            {
                targetZ = z - 1;
                AttakTumbler = true;
                Speed = 5;
            }
        }
        if (targetZ == Enemy1.GetComponent<EnemyBehavior>().targetZ)
            {
                AttakTumbler = false;
           }
        //{
        //    if (Prepyatsviya[i] == 0 && i != Enemy1.GetComponent<EnemyBehavior>().targetZ)
        //    {
        //        targetZ = i;
        //        AttakTumbler = true;
        //        Speed = 5;
        //        break;
        //    }
        //    if (targetZ == Enemy1.GetComponent<EnemyBehavior>().targetZ)
        //    {
        //        AttakTumbler = false;
        //    }
        //}
    }
}