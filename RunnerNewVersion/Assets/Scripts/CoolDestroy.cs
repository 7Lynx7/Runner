using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDestroy : MonoBehaviour {
    public GameObject Particles, Audio,Enemy1, Enemy2;
    public void CoollDestroy()
    {
        GetComponent<MeshRenderer>().enabled = false;
        Particles.GetComponent<ParticleSystem>().Play();
        Audio.GetComponent<AudioSource>().Play();
        GetComponent<OnColisionWithPlayer>().Dangerous = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Enemy1.name && other.name == Enemy2.name) CoollDestroy();
    }
}
