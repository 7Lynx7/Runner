using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject Obj;
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.name == Obj.name)
        {
            Destroy(gameObject);
        }
        
    }

   
    // Update is called once per frame
    void Update () {
	    
	}
}
