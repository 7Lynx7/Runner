using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheсkBoxScript : MonoBehaviour {
    public bool CheckBoxForEnemies;
    public int  CheckBoxNumber;
    public GameObject Player, Enemy, Enemy2;
    public MenuScript Canvas;


    public void OnTriggerWithPillar()
    {
        if (CheckBoxForEnemies)
        {
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                    }
                    break;
                case 2:
                    {
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                    }
                    break;
                case 3:
                    {
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                    }
                    break;
                case 4:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                    }
                    break;
                case 5:
                    {
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                    }
                    break;
                case 6:
                    {
                        //Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]--;
                        //Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]--;
                    }
                    break;
            }
        }
        else
        {   if (Canvas.IsMainMenu)
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                    }
                    break;
                case 2:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                    }
                    break;
                case 3:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                    }
                    break;
                case 4:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                    }
                    break;
                case 5:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                    }
                    break;
                case 6:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                    }
                    break;
            }
        }
    }
    public void OnTriggerWithWallHigh()
    {
        if (CheckBoxForEnemies)
        {
            switch (CheckBoxNumber)
            {
                case 1:
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
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                    }
                    break;
                case 3:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                    }
                    break;
                case 4:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    }
                    break;
                case 5:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
                    }
                    break;
                case 6:
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
        else
        {
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                        
                    }
                    break;
                case 2:
                    {
                        //Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++; 
                        //Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                    }
                    break;
                case 3:
                    {
                       
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                    }
                    break;
                case 4:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                        
                    }
                    break;
                case 5:
                    {
                        //Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                        //Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                    }
                    break;
                case 6:
                    {
                       
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                    }
                    break;
            }
        }
    }
    public void OnTriggerWithWallHighBroad()
    {
        if (CheckBoxForEnemies)
        {
            switch (CheckBoxNumber)
            {
                case 1:
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
                case 3:
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
                case 4:
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
                case 6:
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
        else
        {
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                    }
                    break;
                case 3:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                    }
                    break;
                case 4:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                    }
                    break;
                case 6:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                    }
                    break;
            }
        }
    }
    public void OnTriggerWithWallHighNarrow()
    {
        if (CheckBoxForEnemies)
        {
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                    }
                    break;
                case 3:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
                    }
                    break;
                case 4:
                    {
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
                        Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
                        Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
                    }
                    break;
                case 6:
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
        else
        {
            switch (CheckBoxNumber)
            {
                case 1:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                    }
                    break;
                case 3:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
                    }
                    break;
                case 4:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                    }
                    break;
                case 6:
                    {
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
                        Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
                    }
                    break;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
    
        if(other.name == "PillarCol")
        {
            OnTriggerWithPillar();
        
        }
        if (other.name == "WallHighCol")
        {
            OnTriggerWithWallHigh();
       
        }
        if (other.name == "WallHighBroadCol")
        {
            OnTriggerWithWallHighBroad();
         
        }
        if (other.name == "WallHighNarrowCol")
        {
            OnTriggerWithWallHighNarrow();
     
        }     
    }       
}
