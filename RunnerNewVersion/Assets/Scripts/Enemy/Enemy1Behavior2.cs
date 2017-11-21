using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behavior2 : MonoBehaviour {

    //тут система из пяти рельс а не из трёх как в основном скрипте

    public GameObject Player;

  
    [SerializeField]
    float[] PlayerPosition = new float[5];
 

 

    void FixedUpdate ()
    {
            if (Player.transform.position.x < PlayerPosition[4]) if (GetComponent<EnemyBehavior>().Prepyatsviya[4] == 0) GetComponent<EnemyBehavior>().targetZ = 4;
            if (Player.transform.position.x < PlayerPosition[3]) if (GetComponent<EnemyBehavior>().Prepyatsviya[3] == 0) GetComponent<EnemyBehavior>().targetZ = 3;
            if (Player.transform.position.x < PlayerPosition[2]) if (GetComponent<EnemyBehavior>().Prepyatsviya[2] == 0) GetComponent<EnemyBehavior>().targetZ = 2;
            if (Player.transform.position.x < PlayerPosition[1]) if (GetComponent<EnemyBehavior>().Prepyatsviya[1] == 0) GetComponent<EnemyBehavior>().targetZ = 1;
            if (Player.transform.position.x < PlayerPosition[0]) if (GetComponent<EnemyBehavior>().Prepyatsviya[0] == 0) GetComponent<EnemyBehavior>().targetZ = 0;
    }
}
