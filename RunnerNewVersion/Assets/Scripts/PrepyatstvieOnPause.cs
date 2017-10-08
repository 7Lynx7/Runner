using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepyatstvieOnPause : MonoBehaviour {

    public GameObject Canvas;
	void Update () {
        if (Canvas.GetComponent<MenuScript>().IsPauseMenu) GetComponent<RotateTropinka>().enabled = false;
        else GetComponent<RotateTropinka>().enabled = true;
    }
}
