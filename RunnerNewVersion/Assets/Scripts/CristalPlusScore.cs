using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalPlusScore : MonoBehaviour {
    public GameObject Player, Canvas;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name) Canvas.GetComponent<MenuScript>().Score+=3;
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
