using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
switch (NumberPosition)
        {
            case 0:
                {

                }
                break;
            case 1:
                {

                }
                break;
            case 2:
                {

                }
                break;
        }
*/
public class ChechPositionObstacles : MonoBehaviour {

    public int Type;
    public GameObject Player, Enemy, Enemy2;
    public GameObject Spawner0, Spawner1, Spawner2;
    public int NumberPosition;
    public float PosGGEnter, PosGGExit;
    public float PosEnemyEnter, PosEnemyExit;
    public MenuScript Canvas;
    bool IsNotOriginal;

    private bool CompleteGGEnter, CompleteGGExit, CompleteEnemyEnter, CompleteEnemyExit;

    void Start ()
    {
        if (transform.position.x < Spawner1.transform.position.x )
        {
            NumberPosition = 0;
            IsNotOriginal = true;
        }
        if (transform.position.x == Spawner1.transform.position.x)
        {
            NumberPosition = 1;
            IsNotOriginal = true;
        }
        if (transform.position.x > Spawner1.transform.position.x && transform.position.x < Spawner2.transform.position.x + 0.5)
        {
            NumberPosition = 2;
            IsNotOriginal = true;
        }
      
        //Debug.Log(transform.position.x);
    }
	

	void Update ()
    {
        if(IsNotOriginal)
        {
            if (transform.position.z > PosGGEnter && Canvas.IsMainMenu && CompleteGGEnter == false)
            {
                switch (Type)
                {
                    case 1:
                        {
                            PillarGGEnter();
                        }
                        break;
                    case 2:
                        {
                            WallHighGGEnter();
                        }
                        break;
                    case 3:
                        {
                            WallHighBroadGGEnter();
                        }
                        break;
                    case 4:
                        {
                            WallHighNarrowGGEnter();
                        }
                        break;
                }
                CompleteGGEnter = true;
            }
            if (transform.position.z > PosGGExit && Canvas.IsMainMenu && CompleteGGExit == false)
            {
                switch (Type)
                {
                    case 1:
                        {
                            PillarGGExit();
                        }
                        break;
                    case 2:
                        {
                            WallHighGGExit();
                        }
                        break;
                    case 3:
                        {
                            WallHighBroadGGExit();
                        }
                        break;
                    case 4:
                        {
                            WallHighNarrowGGExit();
                        }
                        break;
                }
                CompleteGGExit = true;
            }
            if (transform.position.z > PosEnemyEnter && CompleteEnemyEnter == false)
            {
                switch (Type)
                {
                    case 1:
                        {
                            PillarEnemyEnter();
                        }
                        break;
                    case 2:
                        {
                            WallHighEnemyEnter();
                        }
                        break;
                    case 3:
                        {
                            WallHighBroadEnemyEnter();
                        }
                        break;
                    case 4:
                        {
                            WallHighNarrowEnemyEnter();
                        }
                        break;
                }
                CompleteEnemyEnter = true;
            }
            if (transform.position.z > PosEnemyExit && CompleteEnemyExit == false)
            {
                switch (Type)
                {
                    case 1:
                        {
                            PillarEnemyExit();
                        }
                        break;
                    case 2:
                        {
                            WallHighEnemyExit();
                        }
                        break;
                    case 3:
                        {
                            WallHighBroadEnemyExit();
                        }
                        break;
                    case 4:
                        {
                            WallHighNarrowEnemyExit();
                        }
                        break;
                }
                CompleteEnemyExit = true;
            }
        }
    }

    private void PillarGGEnter()
    {
        Player.GetComponent<PlayerPassive>().Prepyatsviya[NumberPosition]++;
    }
    private void PillarGGExit()
    {
        Player.GetComponent<PlayerPassive>().Prepyatsviya[NumberPosition]--;
    }
    private void PillarEnemyEnter()
    {
        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[NumberPosition * 2]++;
        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[NumberPosition * 2]++;
    }
    private void PillarEnemyExit()
    {
        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[NumberPosition * 2]--;
        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[NumberPosition * 2]--;
    }
  
    private void WallHighGGEnter()
    {
        PillarGGEnter();
    }
    private void WallHighGGExit()
    {
        PillarGGExit();
    }
    private void WallHighEnemyEnter()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                }
                break;
            case 1:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                }
                break;
        }
    }
    private void WallHighEnemyExit()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                }
                break;
            case 1:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]--;
                }
                break;
        }
    }

    private void WallHighBroadGGEnter()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                }
                break;
            case 2:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                }
                break;
        }

    }
    private void WallHighBroadGGExit()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                }
                break;
            case 2:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                }
                break;
        }

    }
    private void WallHighBroadEnemyEnter()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                }
                break;
        }

    }
    private void WallHighBroadEnemyExit()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]--;
                }
                break;
        }

    }

    private void WallHighNarrowGGEnter()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                }
                break;
            case 2:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                }
                break;
        }
    }
    private void WallHighNarrowGGExit()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                }
                break;
            case 2:
                {
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                    Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                }
                break;
        }
    }
    private void WallHighNarrowEnemyEnter()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                }
                break;
        }

    }
    private void WallHighNarrowEnemyExit()
    {
        switch (NumberPosition)
        {
            case 0:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                }
                break;
            case 2:
                {
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                    Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                    Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]--;
                }
                break;
        }
    }


}
