using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public GameObject Stolb;
    public GameObject Wall, WallHigh, WallHighBroad, WallHighNarrow,/* WallHighBreakable,*/ Plac;
    public GameObject RotateObs;
    public float time, GlobalTime;
    public int TimeToSpawn;
    public int rand;
    public int rand2;
    public GameObject PositionStolb1;
    public GameObject PositionStolb2;
    public GameObject PositionStolb3;
    public GameObject Cristal;
    public MenuScript Canvas;

    public AnimationCurve TimeScale, SpawnSpeed;

    public float TimeFactor, GlobalTimeFactor;

    void CreateWall()
    {

    }
    public float[] PosPillar = new float[3];
    void CreateTower(int x)
    {
     if (x == 1) Instantiate(Stolb, PositionStolb1.transform.position + new Vector3(PosPillar[0], PosPillar[1], PosPillar[2]), PositionStolb1.transform.rotation, RotateObs.transform);
     if (x == 2) Instantiate(Stolb, PositionStolb2.transform.position + new Vector3(0f, PosPillar[1], PosPillar[2]), PositionStolb1.transform.rotation, RotateObs.transform);
     if (x == 3) Instantiate(Stolb, PositionStolb3.transform.position + new Vector3(-PosPillar[0], PosPillar[1], PosPillar[2]), PositionStolb1.transform.rotation, RotateObs.transform);

    }
    public float[] PosWall = new float[3];
    void CreateWall(int x)
    {
        if (x == 1) Instantiate(Wall, PositionStolb1.transform.position + new Vector3(PosWall[0], PosWall[1], PosWall[2]), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 2) Instantiate(Wall, PositionStolb2.transform.position + new Vector3(0, PosWall[1], PosWall[2]), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 3) Instantiate(Wall, PositionStolb3.transform.position + new Vector3(-PosWall[0], PosWall[1], PosWall[2]), PositionStolb1.transform.rotation, RotateObs.transform);

    }
    public float AngleWallHigh;
    public float[] PosWallHigh = new float[3];
    void CreateWallHigh(int x)
    {
        if (x == 1) Instantiate(WallHigh, PositionStolb1.transform.position + new Vector3(PosWallHigh[0], PosWallHigh[1], PosWallHigh[2]),
            Quaternion.Euler(
            PositionStolb1.transform.rotation.eulerAngles.x + AngleWallHigh,
            PositionStolb1.transform.rotation.eulerAngles.y,
           /*PositionStolb1.transform.rotation.eulerAngles.z*/ 0f
            ),
            RotateObs.transform);
        if (x == 2) Instantiate(WallHigh, PositionStolb2.transform.position + new Vector3(0, PosWallHigh[1], PosWallHigh[2]),
            Quaternion.Euler(
            PositionStolb1.transform.rotation.eulerAngles.x + AngleWallHigh,
            PositionStolb1.transform.rotation.eulerAngles.y,
           /*PositionStolb1.transform.rotation.eulerAngles.z*/ 0f
            ), 
            RotateObs.transform);
        if (x == 3) Instantiate(WallHigh, PositionStolb3.transform.position + new Vector3(-PosWallHigh[0], PosWallHigh[1], PosWallHigh[2]),
            Quaternion.Euler(
            PositionStolb1.transform.rotation.eulerAngles.x + AngleWallHigh,
            PositionStolb1.transform.rotation.eulerAngles.y,
            /*PositionStolb1.transform.rotation.eulerAngles.z*/ 0f
            ),
            RotateObs.transform);

    }
    public float AngleWallHighBroad;
    public float[] PosWallHighBroad = new float[3];
    void CreateWallHighBroad(int x)
    {
        if (x == 1) Instantiate(WallHighBroad, PositionStolb1.transform.position +
            new Vector3(PosWallHighBroad[0], PosWallHighBroad[1], PosWallHighBroad[2]), 
            Quaternion.Euler(
            /*PositionStolb1.transform.rotation.eulerAngles.x +*/ AngleWallHighBroad,
            /*PositionStolb1.transform.rotation.eulerAngles.y*/ + 180,
            /*PositionStolb1.transform.rotation.eulerAngles.z*/ 0f
            ),
            RotateObs.transform);
        if (x == 2) Instantiate(WallHighBroad, PositionStolb3.transform.position + new Vector3(-PosWallHighBroad[0], PosWallHighBroad[1], PosWallHighBroad[2]),
            Quaternion.Euler(
            /*PositionStolb1.transform.rotation.eulerAngles.x + */-AngleWallHighBroad,
           /* PositionStolb1.transform.rotation.eulerAngles.y*/ + 0,
           /* PositionStolb1.transform.rotation.eulerAngles.z*/ +  0 
            ),
            RotateObs.transform);

    }
    public float AngleWallHighNarrow;
    public float[] PosWallHighNarrow = new float[3];
    void CreateWallHighNarrow(int x)
    {
        if (x == 1) Instantiate(WallHighNarrow, PositionStolb1.transform.position + new Vector3(PosWallHighNarrow[0], PosWallHighNarrow[1], PosWallHighNarrow[2]),
            Quaternion.Euler(
            /*PositionStolb1.transform.rotation.eulerAngles.x +*/ -AngleWallHighNarrow,
            /*PositionStolb1.transform.rotation.eulerAngles.y*/ + 0,
          /*  PositionStolb1.transform.rotation.eulerAngles.z*/ + 0
            ),
            RotateObs.transform);
        if (x == 2) Instantiate(WallHighNarrow, PositionStolb3.transform.position + new Vector3(-PosWallHighNarrow[0], PosWallHighNarrow[1], PosWallHighNarrow[2]),
            Quaternion.Euler(
            /*PositionStolb1.transform.rotation.eulerAngles.x +*/ AngleWallHighNarrow,
            /*PositionStolb1.transform.rotation.eulerAngles.y */+ 180,
            /*PositionStolb1.transform.rotation.eulerAngles.z */+ 0
            ),
 RotateObs.transform);

    }
    public float AnglePlac;
    public float[] PosPlac = new float[3];
    void CreatePlac()
    {
       
         Instantiate(Plac, PositionStolb2.transform.position + new Vector3(0, PosPlac[1], PosPlac[2]),
            Quaternion.Euler(
            PositionStolb1.transform.rotation.eulerAngles.x + AnglePlac,
            PositionStolb1.transform.rotation.eulerAngles.y,
            PositionStolb1.transform.rotation.eulerAngles.z
            ),
            RotateObs.transform);
       

    }
    //void CreateWallBreakable(int x)
    //{
    //    if (x == 1) Instantiate(WallHighBreakable, PositionStolb1.transform.position + new Vector3(4.5f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);
    //    if (x == 2) Instantiate(WallHighBreakable, PositionStolb2.transform.position + new Vector3(0f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);
    //    if (x == 3) Instantiate(WallHighBreakable, PositionStolb3.transform.position + new Vector3(-4.5f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);

    //}
    void CreateCristal(int x)
    {
        if (x == 3) Instantiate(Cristal, PositionStolb1.transform.position + new Vector3(0f, 14f, 15f), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 4) Instantiate(Cristal, PositionStolb2.transform.position + new Vector3(0f, 14f, 15f), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 5) Instantiate(Cristal, PositionStolb3.transform.position + new Vector3(0f, 14f, 15f), PositionStolb1.transform.rotation, RotateObs.transform);
    }
    void FixedUpdate()
    {
        GlobalTime += (Time.deltaTime*0.001f * GlobalTimeFactor);
        time += Time.deltaTime*TimeFactor;
        Time.timeScale = TimeScale.Evaluate(GlobalTime);

        if (time > SpawnSpeed.Evaluate(GlobalTime*100))
        {
            time = 0;
            //if (TimeToSpawn>20)
            //    TimeToSpawn-=2;
            if (Canvas.IsMainMenu) rand = UnityEngine.Random.Range(4, 13);
            else
                rand = UnityEngine.Random.Range(1, 15);
            if (rand == 1)
            {
                CreatePlac();
                CreateCristal(UnityEngine.Random.Range(2, 6));
            }
           // if (rand == 2) CreateWallBreakable(UnityEngine.Random.Range(1, 4));
            if (rand == 3)
            {
                rand2 = UnityEngine.Random.Range(1, 4);
                if (rand2 == 1)
                {
                    CreateWall(rand2);
                    CreateCristal(UnityEngine.Random.Range(2, 6));
                }
                if (rand2 == 2)
                {
                    CreateWall(rand2);
                    CreateCristal(UnityEngine.Random.Range(2, 6));
                }
                if (rand2 == 3)
                {
                    CreateWall(rand2);
                    CreateCristal(UnityEngine.Random.Range(2, 6));
                }
            }
            if (rand == 4) CreateWallHigh(UnityEngine.Random.Range(1, 4));
            if (rand == 5) CreateWallHighNarrow(UnityEngine.Random.Range(1, 3));
            if (rand == 6) CreateWallHighBroad(UnityEngine.Random.Range(1, 3));
            if (rand > 6 && rand < 13)
            {
                
                rand2 = UnityEngine.Random.Range(1, 4);
                if (rand2 == 1)
                {
                    CreateTower(rand2);
                }
                if (rand2 == 2)
                {
                    CreateTower(rand2);
                }
                if (rand2 == 3)
                {
                    CreateTower(rand2);
                }
            }
            if (rand > 10)
            {
                CreateCristal(UnityEngine.Random.Range(3, 6));
            }
        }
        

        
    }
}
