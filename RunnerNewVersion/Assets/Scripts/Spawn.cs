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
    public GameObject Wall;
    public GameObject RotateObs;
    public int time;
    public int TimeToSpawn;
    public int rand;
    public int rand2;
    public GameObject PositionStolb1;
    public GameObject PositionStolb2;
    public GameObject PositionStolb3;

    void CreateWall()
    {

    }
    void CreateTower(int x)
    {
     if (x == 1) Instantiate(Stolb, PositionStolb1.transform.position , PositionStolb1.transform.rotation, RotateObs.transform);
     if (x == 2) Instantiate(Stolb, PositionStolb2.transform.position, PositionStolb1.transform.rotation, RotateObs.transform);
     if (x == 3) Instantiate(Stolb, PositionStolb3.transform.position, PositionStolb1.transform.rotation, RotateObs.transform);

    }
    void CreateWall(int x)
    {
        if (x == 1) Instantiate(Wall, PositionStolb1.transform.position + new Vector3(0f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 2) Instantiate(Wall, PositionStolb2.transform.position + new Vector3(0f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);
        if (x == 3) Instantiate(Wall, PositionStolb3.transform.position + new Vector3(0f, 0.75f, 0.5f), PositionStolb1.transform.rotation, RotateObs.transform);

    }
    void FixedUpdate()
    {
        time++;
        if (time > TimeToSpawn)
        {
            time = 0;
            if (TimeToSpawn>30)
                TimeToSpawn-=5;
            rand = UnityEngine.Random.Range(1, 4);
            if (rand == 1)
            {
                rand2 = UnityEngine.Random.Range(1, 4);
                if (rand2 == 1)
                {
                    CreateWall(rand2);
                }
                if (rand2 == 2)
                {
                    CreateWall(rand2);
                }
                if (rand2 == 3)
                {
                    CreateWall(rand2);
                }
            }
            if (rand > 1)
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
        }
        

        
    }
}
