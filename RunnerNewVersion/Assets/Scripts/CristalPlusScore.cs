using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalPlusScore : MonoBehaviour {
    public GameObject Player, Canvas, AS;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == Player.name)
        {
            AS.GetComponent<AudioSource>().Play();
            Canvas.GetComponent<MenuScript>().Score += 3;
            gameObject.GetComponent<MeshRenderer>().enabled = false;

        }
        if (other.name == "Cube") Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
