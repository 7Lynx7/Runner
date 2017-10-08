using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeth : MonoBehaviour {

    public GameObject Bullet, Pillar, Wall, Particle, Player, Canvas,PlayerPrefab, YouLose;

    public bool DeathPassiveRotate = false, TimerToMenu = false;

    public float TIME, koef, TimeToMenu = 0;

    private void OnTriggerEnter(Collider Other)
    {
       // if (Other.name == Bullet.name || Other.name == Pillar.name || Other.name == Wall.name)
            Death();
    }
    void Death()
    {
        Particle.GetComponent<ParticleSystem>().Play();
        Player.SetActive(false);
        GetComponent<Controls>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        DeathPassiveRotate = true;
        TimerToMenu = true;

        YouLose.SetActive(true);
    }

    void StartGame()
    {
        TIME = -1f;
        koef = 1;
        TimerToMenu = false;
        TimeToMenu = 0;
        transform.position = PlayerPrefab.transform.position;
        DeathPassiveRotate = false;
        YouLose.SetActive(false);
        Canvas.GetComponent<MenuScript>().PlayerDeath();
    }

    private void Update()
    {
        if (DeathPassiveRotate)
        {
            TIME += Time.deltaTime;
            koef =  TIME * TIME;    
        }

        if (koef < 0.1)
        {
            koef = 0;
            DeathPassiveRotate = false;
        }

        if (Input.GetKeyDown(KeyCode.Space)) TimeToMenu = 4;

        if (TimerToMenu)
        {
            TimeToMenu += Time.deltaTime;
            if(TimeToMenu>3)
            {
                StartGame();
            }
        }
    }

}
