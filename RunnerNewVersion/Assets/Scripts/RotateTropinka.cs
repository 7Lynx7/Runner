using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTropinka : MonoBehaviour {
    public float koef;
   // public GameObject Player;
    // Use this for initialization
    void Start () {
       // koef = 1;
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void FixedUpdate()
    {
       // koef = Player.GetComponent<PlayerDeth>().koef;
        transform.Rotate(new Vector3( - 0.1f * koef, 0f, 0f));
    }
}
