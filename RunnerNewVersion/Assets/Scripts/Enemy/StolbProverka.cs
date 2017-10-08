using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StolbProverka : MonoBehaviour {

    public GameObject Player;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject CheckStolbVxod1;
    public GameObject CheckStolbVxod2;
    public GameObject CheckStolbVxod3;
    public GameObject CheckStolbVixod1;
    public GameObject CheckStolbVixod2;
    public GameObject CheckStolbVixod3;

    public GameObject CheckStolbVxod1P;
    public GameObject CheckStolbVxod2P;
    public GameObject CheckStolbVxod3P;
    public GameObject CheckStolbVixod1P;
    public GameObject CheckStolbVixod2P;
    public GameObject CheckStolbVixod3P;

    public GameObject Canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == CheckStolbVxod1.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]++;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
        }
        if (other.name == CheckStolbVxod2.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]++;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]++;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
        }
        if (other.name == CheckStolbVxod3.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]++;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]++;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]++;
        }
        if (other.name == CheckStolbVixod1.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[0]--;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[0]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
        }
        if (other.name == CheckStolbVixod2.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[1]--;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[2]--;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[1]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[2]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
        }
        if (other.name == CheckStolbVixod3.name)
        {
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[3]--;
            Enemy.GetComponent<EnemyBehavior>().Prepyatsviya[4]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[3]--;
            Enemy2.GetComponent<Enemy2Behavior>().Prepyatsviya[4]--;
        }
        if (Canvas.GetComponent<MenuScript>().IsMainMenu)
        {
            if (other.name == CheckStolbVxod1P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[0]++;
            if (other.name == CheckStolbVxod2P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[1]++;
            if (other.name == CheckStolbVxod3P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[2]++;
            if (other.name == CheckStolbVixod1P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[0]--;
            if (other.name == CheckStolbVixod2P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[1]--;
            if (other.name == CheckStolbVixod3P.name)
                Player.GetComponent<PlayerPassive>().Prepyatsviya[2]--;
        }
    }

}