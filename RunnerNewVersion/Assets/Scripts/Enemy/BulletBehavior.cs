using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public bool IsFirst, IsMove;
    public float Speed,SpeedAngle,NegativeSpeed;
    public GameObject Canvas, Pushka, Particles, Audio;

    private void Start()
    {
        if (gameObject.name != "Bullet")
        IsFirst = false;
    }

    void Update () {
        if (IsFirst == false && IsMove)
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(transform.rotation.x - 90 - SpeedAngle * time, transform.rotation.y, transform.rotation.z);
        }
    }
    public int time;
    public int TimeToDestroy;
    private void FixedUpdate()
    {
        if (IsFirst == false && IsMove)
        {
            time++;
            if (time >= TimeToDestroy)
            {
                Destroy(gameObject);
            }
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pushka001(Clone)" /*&& Canvas.GetComponent<MenuScript>().IsGame*/ && GetComponent<OnColisionWithPlayer>().Dangerous == true)
        {
            SelfDestroy();
        }
    }
  
    void SelfDestroy()
    {
        GetComponent<MeshRenderer>().enabled = false;
        Particles.GetComponent<ParticleSystem>().Play();
        Audio.GetComponent<AudioSource>().Play();
        GetComponent<OnColisionWithPlayer>().Dangerous = false;
        Speed = NegativeSpeed;
    }

}
