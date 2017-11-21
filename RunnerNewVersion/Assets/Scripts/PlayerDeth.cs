using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeth : MonoBehaviour {

    public GameObject Bullet, Pillar, Wall, Particle, Particle2, Player, Canvas, YouLose;

    public bool DeathPassiveRotate = false, TimerToMenu = false;

    public float TIME, koef, TimeToMenu = 0;

    //private void OnTriggerEnter(Collider Other)
    //{
    //   // if (Other.name == Bullet.name || Other.name == Pillar.name || Other.name == Wall.name)
    //        Death();
    //}
    public GameObject LossSound;
    public void Death()
    {
        Particle.GetComponent<ParticleSystem>().Play();
        Player.GetComponent<MeshRenderer>().enabled = false;
        Player.GetComponent<Rigidbody>().velocity = new Vector3();
        Particle2.SetActive(false);
        GetComponent<Controls>().Controlled = false;
        GetComponent<MeshCollider>().enabled = false;
        DeathPassiveRotate = true;
        TimerToMenu = true;
        Canvas.GetComponent<MenuScript>().IsGame = false;
        YouLose.SetActive(true);
        LossSound.GetComponent<AudioSource>().Play();
        Canvas.GetComponent<MenuScript>().AlreadyDead = true;
    }

    public void ToMenu()
    {
        TIME = -1f;
        koef = 4;
        TimerToMenu = false;
        TimeToMenu = 0;
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


        if (TimerToMenu)
        {
            TimeToMenu += Time.deltaTime;
            if(TimeToMenu>3)
            {
                ToMenu();
            }
        }
    }

}
