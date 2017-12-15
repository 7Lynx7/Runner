using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColisionWithPlayer : MonoBehaviour {

    public GameObject Player, Canvas, Particles, Audio, Enemy1, Enemy2;
    public bool Dangerous = true, IsBullet;

    public void CoollDestroy()
    {
        GetComponent<MeshRenderer>().enabled = false;
        Particles.GetComponent<ParticleSystem>().Play();
        Audio.GetComponent<AudioSource>().Play();
        Dangerous = false;
    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name && Canvas.GetComponent<MenuScript>().IsGame && Dangerous) 
        {
            Player.GetComponent<PlayerDeth>().Death(); 
        }
        if (((other.name == Enemy1.name || other.name == Enemy2.name || other.name == "Enemy1 (Clone)(Clone)" || other.name == "Enemy2 (Clone)(Clone)") && Dangerous && IsBullet == false)
            ||
            (other.name == Player.name && (Canvas.GetComponent<MenuScript>().timerInvulnerability || Canvas.GetComponent<MenuScript>().IsMainMenu))) CoollDestroy();
    }

}
