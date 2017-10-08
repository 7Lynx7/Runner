using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnPause : MonoBehaviour {
    public GameObject Canvas;
    void Update()
    {
        if (Canvas.GetComponent<MenuScript>().IsPauseMenu)
        {
            GetComponent<BulletBehavior>().IsMove = false;
            transform.Translate(Vector3.up * 0);
        }
        else
        {
            GetComponent<BulletBehavior>().IsMove = true;
        }
    }
}
