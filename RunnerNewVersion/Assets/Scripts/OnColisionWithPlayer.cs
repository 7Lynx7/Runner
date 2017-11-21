using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColisionWithPlayer : MonoBehaviour {

    public GameObject Player,Canvas;
    public bool Dangerous = true;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name && Canvas.GetComponent<MenuScript>().IsGame && Dangerous) 
        {
            Player.GetComponent<PlayerDeth>().Death();
        }
    }

}
