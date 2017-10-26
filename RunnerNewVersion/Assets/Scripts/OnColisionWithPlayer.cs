using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColisionWithPlayer : MonoBehaviour {

    public GameObject Player,Canvas;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name && Canvas.GetComponent<MenuScript>().IsGame) 
        {
            Player.GetComponent<PlayerDeth>().Death();
        }
    }

}
